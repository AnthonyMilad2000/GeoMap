using GeoMap.Enums;
using GeoMap.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Utility
{
    public class DrawingState
    {
        public GEOType CurrentType { get; set; }
        public int SelectedId { get; set; } = -1;

        public bool IsAddingPoint { get; set; }
        public bool IsDrawingLine { get; set; }
        public bool IsDrawingPolygon { get; set; }

        public List<PointF> TempPoints { get; set; } = new List<PointF>();
        public List<Feature> AllFeatures = new List<Feature>();
        public string LastGeometry { get; set; }
        public bool IsDrawingActive => IsAddingPoint || IsDrawingLine || IsDrawingPolygon;

    }
}
