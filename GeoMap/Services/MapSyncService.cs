using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public class MapSyncService : IMapSyncService
    {
        private readonly IFeatureService _service;
        private readonly IGisFeatureRenderer _renderer;
        private readonly GisContext _context;

        public MapSyncService(
            IFeatureService service,
            IGisFeatureRenderer renderer,
            GisContext context)
        {
            _service = service;
            _renderer = renderer;
            _context = context;
        }

        public async Task RefreshAsync()
        {
            var features = await _service.GetAllAsync();

            _renderer.Render(features.ToList(), _context);
        }

        public void ClearLayers()
        {
            _context.LineLayer.EditClear();
            _context.PolygonLayer.EditClear();
            _context.PointLayer.EditClear();
        }
    }
}
