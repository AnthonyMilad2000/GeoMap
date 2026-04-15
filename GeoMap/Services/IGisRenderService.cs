using MapWinGIS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public interface IGisRenderService
    {
        string DrawLine(Shapefile layer, List<PointF> points, int fefeatureId);
        string DrawPolygon(Shapefile layer, List<PointF> points, int fefeatureId);
        string DrawPoint(Shapefile layer, PointF point, int featureId);

        string DrawLine(Shapefile layer, List<PointF> points);
        string DrawPolygon(Shapefile layer, List<PointF> points);
        string DrawPoint(Shapefile layer, PointF point);
        Shape CreatePoint(double x, double y);
        Shape CreateLine(List<PointF> points);
        Shape CreatePolygon(List<PointF> points);
    }
}
