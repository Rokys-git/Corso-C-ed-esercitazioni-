using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPubblica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerificaController : ControllerBase
    {
        [HttpGet]
        [Route("Test")]
        public string Test() {
            return "API Raggiungibili";
        }
    }//controllore
}
