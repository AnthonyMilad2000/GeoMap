using GeoMap.DataAccess;
using GeoMap.Repository;
using GeoMap.Repository.IReposiotry;
using GeoMap.Services;
using GeoMap.UI;
using GeoMap.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMap
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var db = new ApplicationDBContext();

            IFeatureRepository repo = new FeatureRepository(db);
            IFeatureService service = new FeatureService(repo);
            IGeometryService geometryService = new GeometryService();
            IGisRenderService gisRenderService = new GisRenderService();
            DrawingState drawingState = new DrawingState();
            GisContext context = new GisContext();
            IGisInitializer gisInitializer = new GisInitializer();
            IGisFeatureRenderer gisFeatureRenderer = new GisFeatureRenderer(geometryService, gisRenderService);
            IMapSyncService mapSyncService = new MapSyncService(service, gisFeatureRenderer, context);

        Application.Run(new Home(service, geometryService, gisRenderService,
            context, drawingState, gisInitializer,gisFeatureRenderer,mapSyncService));

        }
    }
}
