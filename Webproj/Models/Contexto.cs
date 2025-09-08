using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Webproj.Models
{
    public class Contexto : IdentityDbContext<ApplicationUser>
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 
        }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Universo> Universos { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<Faccao> Faccoes { get; set; }
    }
}
