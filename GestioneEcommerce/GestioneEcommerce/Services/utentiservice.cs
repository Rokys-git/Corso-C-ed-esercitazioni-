using GestioneEcommerce.Dtos;
using GestioneEcommerce.Models;

namespace GestioneEcommerce.Services
{
    public class utentiservice : iutentiservice <UtentiDto>
    {

       public bool Inserisci(UtentiDto NuovoUtente)
        {
            bool result = false;
            Utenti utenti = new Utenti();
            NuovoUtente.citta = NuovoUtente.citta;
            NuovoUtente.Email = NuovoUtente.Email;
            string sCognome = "";
            string sNome = "" ;
            string [] arrValori = NuovoUtente.Nominativo.Split("");
            sCognome = arrValori [0];
            sNome = arrValori[1];
            NuovoUtente.Cognome= sCognome;
            NuovoUtente.Nome = sNome;
            NuovoUtente.indirizzo= NuovoUtente.indirizzo;

            result = _repo.nuovoins(NuovoUtente);



            return true; 
        }
    }
}
