using Microsoft.EntityFrameworkCore;
using ProductOnline.Models;

namespace ProductOnline.Repositories
{
    public class CollectionContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connStr = "Server=localhost;Port=3306;Database=apnidukaan;User=root;password=Shiv@1234;";
            optionsBuilder.UseMySQL(connStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Description);
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.ImageUrl);
                entity.Property(e => e.Quantity);
            });
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
