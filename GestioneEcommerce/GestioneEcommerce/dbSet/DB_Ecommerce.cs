using GestioneEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace GestioneEcommerce.dbSet
{
    public class DB_Ecommerce : DbContext
    {
        public DB_Ecommerce(DbContextOptions<DB_Ecommerce> options) : base(options)
        {

        }
        public DbSet<Utenti> DsUtenti { get; set; }
    }
}
