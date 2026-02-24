using CafetinSena.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CafetinSena.Infrastructure.Data
{
    public class CafetinDbContext : DbContext
    {
        public CafetinDbContext(DbContextOptions<CafetinDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasPrecision(18, 2);
        }
    }
}