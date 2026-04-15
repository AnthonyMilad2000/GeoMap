using GeoMap.Models;
using MapWinGIS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GeoMap.Services
{
    public class GisRenderService : IGisRenderService
    {
        public Shape CreatePoint(double x, double y)
        {
            var shape = new Shape();
            shape.Create(ShpfileType.SHP_POINT);
            shape.AddPoint(x, y);
            return shape;
        }

        public Shape CreateLine(List<PointF> points)
        {
            var shape = new Shape();
            shape.Create(ShpfileType.SHP_POLYLINE);

            foreach (var p in points)
                shape.AddPoint(p.X, p.Y);

            return shape;
        }

        public Shape CreatePolygon(List<PointF> points)
        {
            var shape = new Shape();
            shape.Create(ShpfileType.SHP_POLYGON);

            foreach (var p in points)
                shape.AddPoint(p.X, p.Y);

            return shape;
        }

        public string DrawPoint(Shapefile layer, PointF p, int featureId)
        {
            var shape = CreatePoint(p.X, p.Y);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            int fieldIndex = layer.FieldIndexByName["FeatureId"];
            if (fieldIndex == -1)
            {
                var field = new Field();
                field.Name = "FeatureId";
                field.Type = FieldType.INTEGER_FIELD;

                layer.EditInsertField(field, 0, null);
                fieldIndex = 0;
            }

            layer.EditInsertShape(shape, ref idx);


            layer.EditCellValue(fieldIndex, idx, featureId);

            layer.StopEditingShapes(true);

            return $"POINT({p.X} {p.Y})";
        }

        public string DrawLine(Shapefile layer, List<PointF> points, int featureId)
        {
            var shape = CreateLine(points);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            int fieldIndex = layer.FieldIndexByName["FeatureId"];
            if (fieldIndex == -1)
            {
                var field = new Field();
                field.Name = "FeatureId";
                field.Type = FieldType.INTEGER_FIELD;

                layer.EditInsertField(field, 0, null);
                fieldIndex = 0;
            }

            layer.EditInsertShape(shape, ref idx);

            layer.EditCellValue(fieldIndex, idx, featureId);

            layer.StopEditingShapes(true);

            return $"LINESTRING({string.Join(", ", points.Select(p => $"{p.X} {p.Y}"))})";
        }
        public string DrawPolygon(Shapefile layer, List<PointF> points, int featureId)
        {
            var shape = CreatePolygon(points);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            int fieldIndex = layer.FieldIndexByName["FeatureId"];
            if (fieldIndex == -1)
            {
                var field = new Field();
                field.Name = "FeatureId";
                field.Type = FieldType.INTEGER_FIELD;

                layer.EditInsertField(field, 0, null);
                fieldIndex = 0;
            }

            layer.EditInsertShape(shape, ref idx);

            layer.EditCellValue(fieldIndex, idx, featureId);

            layer.StopEditingShapes(true);

            var coords = string.Join(", ", points.Select(p => $"{p.X} {p.Y}"));
            coords += $", {points[0].X} {points[0].Y}";

            return $"POLYGON(({coords}))";
        }

        public string DrawPoint(Shapefile layer, PointF p)
        {
            var shape = CreatePoint(p.X, p.Y);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            layer.EditInsertShape(shape, ref idx);
            layer.StopEditingShapes(true);

            return $"POINT({p.X} {p.Y})";
        }

        public string DrawLine(Shapefile layer, List<PointF> points)
        {
            var shape = CreateLine(points);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            layer.EditInsertShape(shape, ref idx);

            layer.StopEditingShapes(true);

            return $"LINESTRING({string.Join(", ", points.Select(p => $"{p.X} {p.Y}"))})";
        }
        public string DrawPolygon(Shapefile layer, List<PointF> points)
        {
            var shape = CreatePolygon(points);

            int idx = layer.NumShapes;

            layer.StartEditingShapes(true);
            layer.EditInsertShape(shape, ref idx);

            layer.StopEditingShapes(true);

            var coords = string.Join(", ", points.Select(p => $"{p.X} {p.Y}"));
            coords += $", {points[0].X} {points[0].Y}";

            return $"POLYGON(({coords}))";
        }

    }
}