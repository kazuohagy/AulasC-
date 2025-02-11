using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SegundaSesh.Models;

namespace SegundaSesh.Pages
{
    public class PrivacyModel : PageModel
    {
        IConfiguration _configuration;
        public PrivacyModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Nome { get; set; } = "mario";

        public List<Planos> Planos { get; set; } = [];

        public async Task OnGetAsync()
        {
            Planos planos = new();
            Planos = await planos.OnGetAsync(_configuration);
            Nome = "mario";
        }

    }

}
