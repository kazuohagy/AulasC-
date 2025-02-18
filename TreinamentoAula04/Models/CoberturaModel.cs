using Dapper;
using Microsoft.Data.SqlClient;

namespace TreinamentoAula04.Models
{
    public class CoberturaModel
    {
        public int Id { get; set; }
        public string Descritivo { get; set; } = "";

        public async Task<List<CoberturaModel>> GetListaCoberturas(IConfiguration _configuration)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("TestConnection"));
            return (List<CoberturaModel>)await connection.QueryAsync<CoberturaModel>("select * from [coberturas] where tipo = 1");
        }
    }
}
