using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public class GeometryService : IGeometryService
    {
        public string BuildLineString(List<PointF> points)
        {
            var coords = string.Join(", ",
                points.Select(p => $"{p.X} {p.Y}"));

            return $"LINESTRING({coords})";
        }

        public string BuildPoint(PointF p)
        {
            return $"POINT({p.X} {p.Y})";
        }

        public string BuildPolygon(List<PointF> points)
        {
            if (points.Count < 3) return "";

            var coords = string.Join(", ",
                points.Select(p => $"{p.X} {p.Y}"));

            coords += $", {points[0].X} {points[0].Y}";

            return $"POLYGON(({coords}))";
        }

        public List<PointF> ParseLineString(string wkt)
        {
            var points = new List<PointF>();

            var cleaned = wkt.Replace("LINESTRING(", "").Replace(")", "");
            var pairs = cleaned.Split(',');

            foreach (var pair in pairs)
            {
                var coords = pair.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                float x = float.Parse(coords[0]);
                float y = float.Parse(coords[1]);

                points.Add(new PointF(x, y));
            }

            return points;
        }

        public List<PointF> ParsePolygon(string wkt)
        {
            var points = new List<PointF>();

            var cleaned = wkt
                .Replace("POLYGON((", "")
                .Replace("))", "");

            var pairs = cleaned.Split(',');

            foreach (var pair in pairs)
            {
                var coords = pair.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                float x = float.Parse(coords[0]);
                float y = float.Parse(coords[1]);

                points.Add(new PointF(x, y));
            }

            return points;
        }
        public PointF ParsePoint(string wkt)
        {
            if (string.IsNullOrWhiteSpace(wkt))
                return PointF.Empty;

            var cleaned = wkt
                .Replace("POINT", "")
                .Replace("(", "")
                .Replace(")", "")
                .Trim();

            var parts = cleaned.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
                return PointF.Empty;

            float x = float.Parse(parts[0]);
            float y = float.Parse(parts[1]);

            return new PointF(x, y);
        }

    }
}
