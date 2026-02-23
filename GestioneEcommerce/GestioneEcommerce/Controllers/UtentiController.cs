using GestioneEcommerce.Dtos;
using GestioneEcommerce.Models;
using GestioneEcommerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestioneEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtentiController : ControllerBase
    {
        [HttpPost]
        [Route("NuovoUtente")]
        public ActionResult Nuovo(UtentiDto utenti)
        {
            Utenti nuovoUtenti = new Utenti();
            nuovoUtenti.citta = utenti.citta;


            utentiservice.Inserisci(nuovoUtenti);
            return Ok("Nuovo Utente Creato");
        }
    }
}
