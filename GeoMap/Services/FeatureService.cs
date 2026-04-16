using GeoMap.Models;
using GeoMap.Repository.IReposiotry;
using GeoMap.Utility.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMap.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _repo;

        public FeatureService(IFeatureRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Feature>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task AddAsync(Feature feature)
        {
            var result = FeatureValidator.Validate(feature);

            if (!result.IsValid)
                throw new Exception("Validation failed: " + result.Error);

            feature.CreatedAt = DateTime.Now;

            await _repo.AddAsync(feature);
        }

        public async Task UpdateAsync(Feature feature)
        {
            var result = FeatureValidator.Validate(feature);

            if (!result.IsValid)
                throw new Exception("Validation failed: " + result.Error);

            feature.UpdatedAt = DateTime.Now;

            await _repo.UpdateAsync(feature);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }

        public async Task<List<Feature>> SearchByNameAsync(string name)
        {
            return await _repo.SearchByNameAsync(name);
        }
    }
}
