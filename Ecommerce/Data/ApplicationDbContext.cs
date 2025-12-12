using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products { ProductId = 1,  Quantity = 1},
                new Products { ProductId = 2, Quantity = 2 }
                );
        }
    }
    
}
