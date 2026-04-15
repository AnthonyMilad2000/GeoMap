using AxMapWinGIS;
using MapWinGIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public class GisInitializer : IGisInitializer
    {
        public void Initialize(AxMap axMap, GisContext context)
        {
            context.LineLayer = CreateLayer(axMap, MapWinGIS.ShpfileType.SHP_POLYLINE);
            context.PolygonLayer = CreateLayer(axMap, MapWinGIS.ShpfileType.SHP_POLYGON);
            context.PointLayer = CreateLayer(axMap, MapWinGIS.ShpfileType.SHP_POINT);
        }

        private Shapefile CreateLayer(AxMap axMap, MapWinGIS.ShpfileType type)
        {
            var layer = new Shapefile();
            layer.CreateNew("", type);
            axMap.AddLayer(layer, true);
            return layer;
        }
    }
}
