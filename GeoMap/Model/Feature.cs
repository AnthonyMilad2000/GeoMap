using GeoMap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Models
{
    public class Feature
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GEOType Type { get; set; } 

        public string Description { get; set; }

        public string Geometry { get; set; } 

        public string Color { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
