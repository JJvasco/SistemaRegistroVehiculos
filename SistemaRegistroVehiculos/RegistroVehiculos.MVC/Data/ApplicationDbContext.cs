using Microsoft.EntityFrameworkCore;
using RegistroVehiculos.MVC.Models;

namespace RegistroVehiculos.MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasIndex(e => e.Placa).IsUnique();
                entity.Property(e => e.Placa).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Marca).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Modelo).IsRequired();
                entity.Property(e => e.Activo).HasDefaultValue(true);
            });
        }
    }
}
