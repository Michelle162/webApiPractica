using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class equiposContext : DbContext
    {
        public equiposContext(DbContextOptions<equiposContext> options) : base(options)
        {

        }
        public DbSet<equipo> equipos { get; set; }
    }
}
