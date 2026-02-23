using System.ComponentModel.DataAnnotations;

namespace ApiPubblica.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Cognome Obbligatorio")]
        [StringLength(50, ErrorMessage = "Massimo 50 caratteri")]
        public string Cognome { get; set; }
        [Required(ErrorMessage = "Nome Obbligatorio")]
        [StringLength(50, ErrorMessage = "Massimo 50 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Codice fiscale Obbligatorio")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Occorre inserire 16 caratteri")]
        [RegularExpression(@"^[A-Za-z]{6}[0-9]{2}[A-Za-z]{1}[0-9]{2}[A-Za-z]{1}[0-9]{3}[A-Za-z]{1}$")]
        public string CodiceFiscale { get; set; }

        
        [StringLength(5,MinimumLength =5,ErrorMessage ="se proprio devi inserilo scrivilo bene!")]
        public string Cap { get; set; }

    }
}
