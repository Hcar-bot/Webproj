using Microsoft.EntityFrameworkCore;

namespace Webproj.Models
{
    public class Contexto:DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 
        }
         public DbSet <Personagem> Personagens { get; set; }
    }
}
