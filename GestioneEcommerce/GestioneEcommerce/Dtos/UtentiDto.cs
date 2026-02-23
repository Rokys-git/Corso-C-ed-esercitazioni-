namespace GestioneEcommerce.Dtos
{
    public class UtentiDto
    {
        public string DataReg{ get; set; } = "";
        public string Nominativo  { get; set; } = "";
        public string Email { get; set; } = "";
        public string citta { get; internal set; }
        public string Cognome { get; internal set; }
        public string Nome { get; internal set; }
        public object indirizzo { get; internal set; }
    }
}
