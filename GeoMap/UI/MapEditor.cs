using GeoMap.Enums;
using GeoMap.Models;
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
    public partial class MapEditor : Form
    {
        private readonly IFeatureService _service;
        private readonly IGeometryService _geometryService;
        private readonly IGisRenderService _gis;
        private readonly GisContext _gisContext;
        private readonly DrawingState _state;
        private readonly IGisInitializer _gisInitializer;
        private readonly IGisFeatureRenderer _gisRenderer;
        private readonly IMapSyncService _mapSyncService;


        
        private int selectedId = -1;


       


        public MapEditor(IFeatureService service, IGeometryService geometryService,
            IGisRenderService gis, GisContext gisContext,DrawingState state,
            IGisInitializer gisInitializer, IGisFeatureRenderer gisFeatureRenderer,
            IMapSyncService mapSyncService
            )
        {
            InitializeComponent();
            _service = service;
            timer1.Start();
            _geometryService=geometryService;
            dataGridView1.CellClick += dataGridView1_CellClick;
            axMap1.MouseDownEvent += axMap1_MouseDownEvent;
            _gis=gis;
            _gisContext = gisContext;
            _state = state;
            _gisInitializer = gisInitializer;
            _gisRenderer = gisFeatureRenderer;
            _mapSyncService = mapSyncService;
        }


        private async void MapEditor_Load(object sender, EventArgs e)
        {
            try
            {
                _gisInitializer.Initialize(axMap1, _gisContext);

                axMap1.SendMouseDown = true;

                comboTypeBox.DataSource = Enum.GetValues(typeof(GEOType));

                axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;

                await LoadFeaturesFromDb();
                await LoadData();

                axMap1.ZoomToMaxExtents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private async Task LoadFeaturesFromDb()
        {
            try
            {
                var features = await _service.GetAllAsync();

                _gisRenderer.Render(features.ToList(), _gisContext);

                axMap1.Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void OpenStreetMap_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap;
        }

        private void OpenHumanitarian_Click(object sender, EventArgs e)
        {
            axMap1.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var feature = new Feature
                {
                    Name = NameBox.Text,
                    Description = DescriptionBox.Text,
                    Color = ColorBox.Text,
                    Type = _state.CurrentType,
                    Geometry = GeometryBox.Text
                };

                await _service.AddAsync(feature);

                _mapSyncService.ClearLayers();

                await _mapSyncService.RefreshAsync();
                await LoadData();

                axMap1.Redraw();

                MessageBox.Show("Saved Successfully");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeometryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                _state.CurrentType = GEOType.Polygon;
                _state.IsDrawingPolygon = true;

                _state.IsAddingPoint = false;
                _state.IsDrawingLine = false;

                _state.TempPoints.Clear();

                axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                _state.CurrentType = GEOType.Point;
                _state.IsAddingPoint = true;

                _state.IsDrawingLine = false;
                _state.IsDrawingPolygon = false;

                _state.TempPoints.Clear();

                axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
            try
            {
                double x = 0, y = 0;
                axMap1.PixelToProj(e.x, e.y, ref x, ref y);

                if (!_state.IsAddingPoint && !_state.IsDrawingLine && !_state.IsDrawingPolygon)
                {
                    SelectShapeFromMap(x, y);
                    return;
                }
                // ================= POINT =================
                if (_state.IsAddingPoint && _state.CurrentType == GEOType.Point)
                {
                    var shape = new MapWinGIS.Shape();
                    shape.Create(MapWinGIS.ShpfileType.SHP_POINT);
                    shape.AddPoint(x, y);

                    int idx = _gisContext.PointLayer.NumShapes;
                    _gisContext.PointLayer.StartEditingShapes(true);
                    _gisContext.PointLayer.EditInsertShape(shape, ref idx);
                    _gisContext.PointLayer.StopEditingShapes(true);

                    GeometryBox.Text = _gis.DrawPoint(_gisContext.PointLayer, new PointF((float)x, (float)y));

                    _state.IsAddingPoint = false;
                    axMap1.Redraw();
                    return;
                }

                // ================= LINE =================
                if (_state.IsDrawingLine && _state.CurrentType == GEOType.Line)
                {
                    _state.TempPoints.Add(new PointF((float)x, (float)y));

                    
                    if (e.button == 2 && _state.TempPoints.Count >= 2)
                    {
                        GeometryBox.Text = _gis.DrawLine(_gisContext.LineLayer, _state.TempPoints);

                        _state.TempPoints.Clear();
                        _state.IsDrawingLine = false;

                        axMap1.Redraw();
                    }
                    return;
                }

                // ================= POLYGON =================
                if (_state.IsDrawingPolygon && _state.CurrentType == GEOType.Polygon)
                {
                    _state.TempPoints.Add(new PointF((float)x, (float)y));

                    if (e.button == 2 && _state.TempPoints.Count >= 3)
                    {

                        GeometryBox.Text = _gis.DrawPolygon(_gisContext.PolygonLayer, _state.TempPoints);

                        _state.TempPoints.Clear();
                        _state.IsDrawingPolygon = false;

                        axMap1.Redraw();
                    }

                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding point: " + ex.Message);
            }
        }

        private void SelectShapeFromMap(double x, double y)
        {
            double x1 = 0, y1 = 0;
            double x2 = 0, y2 = 0;

            axMap1.PixelToProj(0, 0, ref x1, ref y1);
            axMap1.PixelToProj(5, 5, ref x2, ref y2);

            double tolerance = Math.Abs(x2 - x1);

            // POINT
            if (TrySelectFromLayer(_gisContext.PointLayer, x, y, tolerance, GEOType.Point)) return;

            // LINE
            if (TrySelectFromLayer(_gisContext.LineLayer, x, y, tolerance, GEOType.Line)) return;

            // POLYGON
            if (TrySelectFromLayer(_gisContext.PolygonLayer, x, y, tolerance, GEOType.Polygon)) return;
        }
        private bool TrySelectFromLayer(MapWinGIS.Shapefile layer, double x, double y, double tol, GEOType type)
        {
            
            if (layer == null || layer.NumShapes == 0)
                return false;

            object result = null;

            var extents = new MapWinGIS.Extents();
            extents.SetBounds(x - tol, y - tol, 0, x + tol, y + tol, 0);

            bool selected = layer.SelectShapes(extents, tol, MapWinGIS.SelectMode.INTERSECTION, ref result);

            if (!selected || result == null)
                return false;

            int[] shapes = (int[])result;

            if (shapes.Length > 0)
            {
                int shapeIndex = shapes[0];

                int fieldIndex = layer.FieldIndexByName["FeatureId"];
                int featureId = Convert.ToInt32(layer.CellValue[fieldIndex, shapeIndex]);

                LoadFeatureToForm(featureId, type);

                return true;
            }

            return false;
        }
        private void LoadFeatureToForm(int id, GEOType type)
        {
            var feature = _state.AllFeatures.FirstOrDefault(f => f.Id == id);
            if (feature == null) return;

            selectedId = feature.Id;
            NameBox.Text = feature.Name;
            DescriptionBox.Text = feature.Description;
            ColorBox.Text = feature.Color;
            GeometryBox.Text = feature.Geometry;
            comboTypeBox.SelectedItem = feature.Type;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridView1.Rows[e.RowIndex];

                    selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                    NameBox.Text = row.Cells["Name"].Value.ToString();
                    DescriptionBox.Text = row.Cells["Description"].Value?.ToString();
                    ColorBox.Text = row.Cells["Color"].Value?.ToString();
                    GeometryBox.Text = row.Cells["Geometry"].Value?.ToString();
                    comboTypeBox.SelectedItem =(GEOType)Enum.Parse(typeof(GEOType), row.Cells["Type"].Value.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        
        private void comboTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _state.CurrentType = GEOType.Line;
                _state.IsDrawingLine = true;

                _state.IsAddingPoint = false;
                _state.IsDrawingPolygon = false;

                _state.TempPoints.Clear();

                axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private async void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a record first");
                    return;
                }
                var confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm",
                    MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                await _service.DeleteAsync(selectedId);

                _mapSyncService.ClearLayers();
                await _mapSyncService.RefreshAsync();
                await LoadData();

                selectedId = -1;
                ClearForm();

                axMap1.Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Select record first");
                    return;
                }

                var feature = GetFeatureFromForm();
                await _service.UpdateAsync(feature);

                _mapSyncService.ClearLayers();
                await _mapSyncService.RefreshAsync();
                await LoadData();

                selectedId = -1;
                ClearForm();

                axMap1.Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async Task LoadData()
        {
            try
            {
                var features = (await _service.GetAllAsync()).ToList();

                _state.AllFeatures = features;

                dataGridView1.DataSource = features;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private Feature GetFeatureFromForm()
        {
            return new Feature
            {
                Id = selectedId,
                Name = NameBox.Text.Trim(),
                Description = DescriptionBox.Text.Trim(),
                Type = (GEOType)comboTypeBox.SelectedItem,
                Color = ColorBox.Text.Trim(),
                Geometry = GeometryBox.Text.Trim()
            };
        }
        private void ClearForm()
        {
            NameBox.Text = "";
            DescriptionBox.Text = "";
            ColorBox.Text = "";
            GeometryBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {
            string name = searchBox.Text.Trim();

            var filtered = await _service.SearchByNameAsync(name);

            dataGridView1.DataSource = filtered;
        }
    }
}
