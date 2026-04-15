using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public interface IGeometryService
    {
        string BuildLineString(List<PointF> points);
        string BuildPolygon(List<PointF> points);

        List<PointF> ParseLineString(string wkt);
        List<PointF> ParsePolygon(string wkt);
        PointF ParsePoint(string wkt);
        string BuildPoint(PointF p);
    }
}
