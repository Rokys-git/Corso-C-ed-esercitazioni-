using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConFiltro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetodiController : ControllerBase
    {
        [HttpPost("NuovoInserimento")]
        public AcceptedResult Inserimento()
        {
            return Ok("access");
        }

    }
}
