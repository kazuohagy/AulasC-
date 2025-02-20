using Microsoft.AspNetCore.Mvc;
using setimaSesh.Model;
using setimaSesh.Service;

namespace setimaSesh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KazuoController : ControllerBase
    {
        private readonly PlanoService _planoService;
        public KazuoController(PlanoService planoService)
        {
            _planoService = planoService;
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<ActionResult<List<PlanoModel>>> GetPlanosLista()
        {

            return await _planoService.GetListaPlanos();
        }
    }
}
