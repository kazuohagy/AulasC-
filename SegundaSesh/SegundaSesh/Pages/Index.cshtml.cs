using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Numerics;
using System.Threading.Tasks;
using Dapper;
using SegundaSesh.Models;
using System.Data.SqlClient;

namespace SegundaSesh.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; } = "mario";

        public List<Planos> planos { get; set; }

        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task OnGetAsync()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("TestConnection"));
            planos = (List<Planos>)await connection.QueryAsync<Planos>("SELECT * FROM [planos] WHERE ageid = 0 AND publicado = 1");

        }
    }

    public class Planos
    {
        // Propriedades da classe devem corresponder às colunas da tabela "planos"
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AgeId { get; set; }
        public bool Publicado { get; set; }
    }
}
