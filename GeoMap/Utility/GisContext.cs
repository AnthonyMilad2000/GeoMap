using MapWinGIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
   
        public class GisContext
        {
            public Shapefile PointLayer { get; set; }
            public Shapefile LineLayer { get; set; }
            public Shapefile PolygonLayer { get; set; }

        }
    
}
