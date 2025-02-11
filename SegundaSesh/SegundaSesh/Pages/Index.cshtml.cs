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
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Name { get; set; } = "mario";

        public List<Planos> Planos { get; set; } = [];

        
        public async Task OnGetAsync()
        {
            Planos planos = new();
            Planos = await planos.OnGetAsync(_configuration);
            Name = "mario";

        }
    }

}
