using Dapper;
using Microsoft.Data.SqlClient;
using System.Numerics;

namespace TreinamentoAula04.Models
{
    public class PlanoModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public async Task<List<PlanoModel>> GetListaPlanos(IConfiguration _configuration)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("TestConnection"));
            return (List<PlanoModel>)await connection.QueryAsync<PlanoModel>("SELECT * FROM [planos] WHERE ageid = 0 and publicado = 1");
        }
    }
}
