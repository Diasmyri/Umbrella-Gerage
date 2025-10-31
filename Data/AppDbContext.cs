using Microsoft.EntityFrameworkCore;
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Damaged> Damaged { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                    "Host=localhost;Port=5432;Database=db_vb2_vehicle_repair;Username=postgres;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Damaged>().ToTable("Damaged");
            modelBuilder.Entity<Payment>().ToTable("Payments");

            base.OnModelCreating(modelBuilder);
        }
    }
}
