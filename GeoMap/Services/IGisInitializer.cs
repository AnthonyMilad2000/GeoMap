using AxMapWinGIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public interface IGisInitializer
    {
        void Initialize(AxMap axMap, GisContext context);
    }
}
