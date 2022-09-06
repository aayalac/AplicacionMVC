using AplicacionMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace AplicacionMVC.Data
{
    public class AplicacionMVCDbContext : DbContext
    {
        public DbSet<Estacion> estaciones { get; set; }

        public DbSet<Bus> buses { get; set; }

        public DbSet<Conductor> conductores { get; set; }

        public AplicacionMVCDbContext(DbContextOptions<AplicacionMVCDbContext> options) : base(options)
        {
        }
    }
}
