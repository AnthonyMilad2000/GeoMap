using GeoMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public interface IFeatureService
    {
        Task<List<Feature>> GetAllAsync();
        Task AddAsync(Feature feature);
        Task UpdateAsync(Feature feature);
        Task DeleteAsync(int id);
        Task<List<Feature>> SearchByNameAsync(string name);
    }
}
