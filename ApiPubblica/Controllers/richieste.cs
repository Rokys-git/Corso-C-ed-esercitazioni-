using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPubblica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class richieste : ControllerBase
    {
        [HttpPost]
        [Route("logga")]
        public ActionResult<string> Registra(string valore)
        { 
            return Ok(valore); 
        }
    }
}//controller
