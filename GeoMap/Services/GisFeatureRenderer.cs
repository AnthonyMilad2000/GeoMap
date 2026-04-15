using GeoMap.Enums;
using GeoMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public class GisFeatureRenderer : IGisFeatureRenderer
    {
        private readonly IGeometryService _geometry;
        private readonly IGisRenderService _renderService;

        public GisFeatureRenderer(IGeometryService geometry, IGisRenderService renderService)
        {
            _geometry = geometry;
            _renderService=renderService;
        }

        public void Render(List<Feature> features, GisContext context)
        {
            context.LineLayer.EditClear();
            context.PolygonLayer.EditClear();
            context.PointLayer.EditClear();

            foreach (var feature in features)
            {
                if (string.IsNullOrWhiteSpace(feature.Geometry))
                    continue;

                switch (feature.Type)
                {
                    case GEOType.Line:
                        var linePoints = _geometry.ParseLineString(feature.Geometry);
                        _renderService.DrawLine(context.LineLayer, linePoints, feature.Id);
                        break;

                    case GEOType.Polygon:
                        var polyPoints = _geometry.ParsePolygon(feature.Geometry);
                        _renderService.DrawPolygon(context.PolygonLayer, polyPoints, feature.Id);
                        break;

                    case GEOType.Point:
                        var pt = _geometry.ParsePoint(feature.Geometry);
                        _renderService.DrawPoint(context.PointLayer, pt, feature.Id);
                        break;
                }
            }
        }
    }
}
