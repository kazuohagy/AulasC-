using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SegundaSesh.Models
{
    public class Planos
    {
        public int ID { get; set; }
        public string? Nome { get; set; }

        public async Task<List<Planos>> OnGetAsync(IConfiguration _configuration)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("TestConnection"));
            var planos = (List<Planos>)await connection.QueryAsync<Planos>("SELECT * FROM [planos] WHERE ageid = 0 AND publicado = 1");
            return planos;
        }
    }
}