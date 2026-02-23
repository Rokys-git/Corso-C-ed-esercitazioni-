using WebApplicationConFiltro.Controllers;

namespace WebApplicationConFiltro.Models
{
		public class Autenticazione
	    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Tipo  { get; set; }

        public string Profilo { get; set; }

        }

}