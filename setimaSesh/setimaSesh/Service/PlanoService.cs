using Dapper;
using Microsoft.Data.SqlClient;
using setimaSesh.Model;

namespace setimaSesh.Service
{
    public class PlanoService : IPlanoService
    {
        IConfiguration _configuration;
        public PlanoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<PlanoModel>> GetListaPlanos()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("TestConnection"));
            return (List<PlanoModel>)await connection.QueryAsync<PlanoModel>("select * from [planos] where ageid = 0 and publicado = 1");
        }
    }
}
