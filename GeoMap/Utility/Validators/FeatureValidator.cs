using GeoMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Utility.Validators
{
    public static class FeatureValidator
    {
        public static (bool IsValid, string Error) Validate(Feature feature)
        {
            if (string.IsNullOrWhiteSpace(feature.Name))
                return (false, "Name is required");

            if (string.IsNullOrWhiteSpace(feature.Geometry))
                return (false, "Geometry is required");

            if (string.IsNullOrWhiteSpace(feature.Type.ToString()))
                return (false, "Type is required");

            if (string.IsNullOrWhiteSpace(feature.Color))
                return (false, "Color is required");

            if (string.IsNullOrWhiteSpace(feature.Description))
                return (false, "Description is required");

            return (true, "");
        }
    }
}
