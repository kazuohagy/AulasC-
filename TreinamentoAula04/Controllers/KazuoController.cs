using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TreinamentoAula04.Models;

namespace TreinamentoAula04.Controllers
{
    public class KazuoController : Controller
    {
        IConfiguration _configuration;
        public KazuoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index(string name, string sobrenome, int id = 4)
        {
            PlanosComCoberturasViewModel paxVm = new()
            {
                Nome = name,
                Sobrenome = sobrenome,
                Idade = id
            };

            return View("../Home/Privacy", paxVm);
        }
    }
}
