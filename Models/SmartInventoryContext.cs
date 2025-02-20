using Microsoft.EntityFrameworkCore;

namespace SmartInventory.Models
{
    public class SmartInventoryContext : DbContext
    {
        public SmartInventoryContext(DbContextOptions<SmartInventoryContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Clothing" }
            );

            
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    CategoryId = 1,  
                    Price = 999.99M,
                    QuantityInStock = 50,
                    LowStockThreshold = 5
                },
                new Product
                {
                    Id = 2,
                    Name = "T-shirt",
                    CategoryId = 2,  
                    Price = 19.99M,
                    QuantityInStock = 100,
                    LowStockThreshold = 10
                },
                new Product
                {
                    Id = 3,
                    Name = "Smartphone",
                    CategoryId = 1,  
                    Price = 499.99M,
                    QuantityInStock = 30,
                    LowStockThreshold = 5
                }
            );
        }
    }
}


