using ApproccioClassico.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ApproccioClassico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatiController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DatiController(IConfiguration configuration)
        {
            _configuration = configuration;
        }//Costruttore

        [HttpGet]
        [Route("TestConnessione")]
        public ActionResult<string> TestConnessione()
        {
            string sResult = "";

            //andiamo a prendere la stringa di connessione al db
            string sConnection = "";//conterrà la stringa di connessione al db
            sConnection = _configuration.GetSection("ConnectionStrings").Value.ToString();
            bool bResult = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(sConnection))
                {
                    connection.Open();
                    connection.Close();
                    bResult = true;
                    sResult = "Connessione riuscita";
                }
            }
            catch (Exception ex)
            {
                bResult = false;
                sResult = ex.Message;
            }
            return Ok(sResult);
        }//testConnessione

        [Route("ElencoOrdini")]
        [HttpGet]
        public ActionResult<List<Ordini>> ElencoOrdini()
        {
            //resyituisce l elenco degli ordini: dataora, Nominativo=nome + cognome, email
            List<Ordini> risultato = new List<Ordini>();
            //1. fare la connessione al db
            //2.eseguire la query
            //3. chiudere la connessione
            //4. costruire il risultato

            return Ok(risultato);
        }//ElencoOrdini
    }//controller
}
