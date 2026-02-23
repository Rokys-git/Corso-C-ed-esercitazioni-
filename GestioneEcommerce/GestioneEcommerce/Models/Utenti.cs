
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
namespace GestioneEcommerce.Models

{
    [Table("tbUtenti")]
    public class Utenti
    {
        [Key]
        public int64 id { get; set; }
        public string cognome { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string indirizzo { get; set; }
        public string citta { get; set; }

        [Column("Dataregistazione")]
        public DateTime dtReg { get; set; }


    }
}
