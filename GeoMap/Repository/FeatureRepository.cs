using GeoMap.DataAccess;
using GeoMap.Enums;
using GeoMap.Models;
using GeoMap.Repository.IReposiotry;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMap.Repository
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly ApplicationDBContext _applicationDB;

        public FeatureRepository(ApplicationDBContext applicationDB)
        {
            _applicationDB = applicationDB;
        }
        public async Task<List<Feature>> GetAllAsync()
        {
            var list = new List<Feature>();

            var connection = new NpgsqlConnection(_applicationDB.ConnectionString);
            
                await connection.OpenAsync();

            var cmd = new NpgsqlCommand("SELECT id, name, type, description, geometry, color, created_at, updated_at FROM features", connection);
            var reader = await cmd.ExecuteReaderAsync();
                
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Feature
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                            Type = (GEOType)Enum.Parse(typeof(GEOType), reader.GetString(2)),

                            Description = reader.IsDBNull(3) ? "" : reader.GetString(3),

                            Geometry = reader.IsDBNull(4) ? "" : reader.GetString(4),

                            Color = reader.IsDBNull(5) ? "" : reader.GetString(5),

                            CreatedAt = reader.GetDateTime(6),

                            UpdatedAt = reader.IsDBNull(7)
                            ? DateTime.MinValue
                            : reader.GetDateTime(7)
                        });
                    }
            

            return list;
        }

        public async Task AddAsync(Feature feature)
        {
            var connection = new NpgsqlConnection(_applicationDB.ConnectionString);
            
                await connection.OpenAsync();

                var cmd = new NpgsqlCommand(@"
            INSERT INTO features (name, type, description, geometry, color, created_at)
            VALUES (@name, @type, @description, @geometry, @color, @created_at)
        ", connection);

                cmd.Parameters.AddWithValue("@name", feature.Name);
                cmd.Parameters.AddWithValue("@type", feature.Type.ToString()); 
                cmd.Parameters.AddWithValue("@description", (object)feature.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@geometry", (object)feature.Geometry ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@color", (object)feature.Color ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                await cmd.ExecuteNonQueryAsync();


            
        }


        public async Task DeleteAsync(int id)
        {
            var connection = new NpgsqlConnection(_applicationDB.ConnectionString);
            
                await connection.OpenAsync();

                var cmd = new NpgsqlCommand(
                    "DELETE FROM features WHERE id = @id",
                    connection
                );

                cmd.Parameters.AddWithValue("@id", id);

                await cmd.ExecuteNonQueryAsync();
            
        }

        public async Task UpdateAsync(Feature feature)
        {
            var connection = new NpgsqlConnection(_applicationDB.ConnectionString);
            
                await connection.OpenAsync();

                var cmd = new NpgsqlCommand(@"
            UPDATE features
            SET name = @name,
                type = @type,
                description = @description,
                geometry = @geometry,
                color = @color,
                updated_at = @updated_at
            WHERE id = @id
        ", connection);

                cmd.Parameters.AddWithValue("@id", feature.Id);
                cmd.Parameters.AddWithValue("@name", feature.Name);
                cmd.Parameters.AddWithValue("@type", feature.Type.ToString());
                cmd.Parameters.AddWithValue("@description", (object)feature.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@geometry", (object)feature.Geometry ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@color", (object)feature.Color ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

                await cmd.ExecuteNonQueryAsync();
            
        }
    }
}
