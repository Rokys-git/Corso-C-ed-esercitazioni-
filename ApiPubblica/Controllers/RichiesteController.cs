using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using ApiPubblica.Models;

namespace ApiPubblica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RichiesteController : ControllerBase
    {
        //depence injection
        private readonly IConfiguration _configuration;

        //COSTRUTTORE
        public RichiesteController(IConfiguration configuration) {
            _configuration = configuration;
        }
        //FINE
        [HttpPost]
        [Route("logga")]
        public ActionResult<string>Registra(string valore) {
            //prende il contenuto di valore e la scrive in un file mettendo 
            //data (DD/MM/YYYYY HH.MM.SS) \t [valore]
            
            //dsevo valorizzare _conf2
            string sDir = _configuration.GetSection("path_registrazione").Value.ToString();
            string sNomeFile = _configuration.GetSection("nomeFile").Value.ToString();
            int sFiglio2 = Convert.ToInt32(_configuration.GetSection("chiave padre").GetSection("figlio2").Value);
            string sFile = sDir + "\\" + sNomeFile;

            if (!Directory.Exists(sDir)) {
                Directory.CreateDirectory(sDir);
            }
/*
 * esempio di come creare un file vuoto!
            if (!System.IO.File.Exists(sFile)) { 
                //se non c'è lo creo vuoto
                System.IO.File.Create(sFile);
                
            }
*/
//apro il file registrazione\registrazione.txt in modalita append, cioè accodo tutto quello che arriva
//bisogna mettere il secondo parametro a true
            using (StreamWriter sw = new StreamWriter(sFile, true))
            {
                sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy_ HH.mm.ss")+"\t"+valore);
            }
            return Ok("Tutto registrato");
        }//Logga

        [HttpPost("CriterioSemplice")]
        public ActionResult Validazione(Persona param) {
            return Ok("Fine metodo");
            
        }
        [HttpPost("ValidazioneModello")]
        public IActionResult Modello(Persona param)
        {
          // se non supera la validazione risponde con 400
            return Ok("Modello validato");

        }
    }//controller
}
