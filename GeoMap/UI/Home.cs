using GeoMap.DataAccess;
using GeoMap.Repository;
using GeoMap.Repository.IReposiotry;
using GeoMap.Services;
using GeoMap.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMap.UI
{
    public partial class Home : Form
    {
        private readonly IFeatureService _service;
        private readonly IGeometryService _geometryService;
        private readonly IGisRenderService _gisRenderService;
        private readonly GisContext _gisContext;
        private readonly DrawingState _state;
        private readonly IGisInitializer _gisInitializer;
        private readonly IGisFeatureRenderer _gisFeatureRenderer;
        private readonly IMapSyncService _mapSyncService;
        public Home(IFeatureService service, IGeometryService geometryService, IGisRenderService gisRenderService,
            GisContext gisContext, DrawingState state, IGisInitializer gisInitializer,
            IGisFeatureRenderer gisFeatureRenderer, IMapSyncService mapSyncService)
        {
            InitializeComponent();
            _service = service;
            _geometryService = geometryService;
            _gisRenderService = gisRenderService;
            _gisContext = gisContext;
            _state = state;
            _gisInitializer = gisInitializer;
            _gisFeatureRenderer = gisFeatureRenderer;
            _mapSyncService = mapSyncService;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 form1 = new Form1(_service))
            {
                form1.ShowDialog();
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MapEditor mapEditor = new MapEditor(_service,_geometryService, _gisRenderService, _gisContext,
                _state, _gisInitializer, _gisFeatureRenderer, _mapSyncService);
            mapEditor.ShowDialog();
        }
    }
}
