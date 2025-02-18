using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TreinamentoAula04.Models;
using Dapper;

namespace TreinamentoAula04.Controllers
{
    public class KazuoController : Controller
    {
        IConfiguration _configuration;
        public KazuoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            PlanoModel plano = new();
            CoberturaModel cobertura = new();

            PlanosComCoberturasViewModel pccVm = new()
            {
                Planos = await plano.GetListaPlanos(_configuration),
                Coberturas = await cobertura.GetListaCoberturas(_configuration)
            };
   
            return Json(pccVm);
        }
    }
}
