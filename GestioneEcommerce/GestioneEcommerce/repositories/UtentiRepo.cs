using GestioneEcommerce.Models;

namespace GestioneEcommerce.repositories
{
    public class UtentiRepo : IUtentirepo<Utenti>
    {
      public bool Nuovoinserimento(Utenti entity)
        {
            bool result = false;
            // Implementazione della logica per inserire un nuovo utente nel database
            return true;
        }
    }
}
