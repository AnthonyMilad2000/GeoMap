using GeoMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public interface IGisFeatureRenderer
    {
        void Render(List<Feature> features, GisContext context);
    }
}
