using Microsoft.EntityFrameworkCore;
using WadMikFlix.Models;

namespace WadMikFlix.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Genero>  Generos { get; set; }
        public DbSet<Filme>  Filmes { get; set; }
    }
}
