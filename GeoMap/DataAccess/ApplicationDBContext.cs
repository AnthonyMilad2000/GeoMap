using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.DataAccess
{
    public class ApplicationDBContext
    {
        public string ConnectionString =>
            "Server=localhost;Port=5432;Database=GeoMap;User Id=postgres;Password=@2$3i8S7;";
    }
}
