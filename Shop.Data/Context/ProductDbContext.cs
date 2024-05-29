using Microsoft.EntityFrameworkCore;
using Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apple iPhone 14", Description = "Latest iPhone model", Category = "Electronics", Price = 999.00m },
                new Product { Id = 2, Name = "Nike Air Jordan", Description = "High-performance basketball shoes", Category = "Sports", Price = 180.00m },
                new Product { Id = 3, Name = "Samsung 4K TV", Description = "High-definition TV with 4K resolution", Category = "Electronics", Price = 1299.00m },
                new Product { Id = 4, Name = "Levi's Jeans", Description = "Classic denim jeans", Category = "Clothing", Price = 60.00m },
                new Product { Id = 5, Name = "Canon EOS Camera", Description = "Professional-grade digital camera", Category = "Electronics", Price = 899.00m },
                new Product { Id = 6, Name = "Adidas Superstar Shoes", Description = "Classic basketball shoes", Category = "Sports", Price = 80.00m },
                new Product { Id = 7, Name = "Sony PlayStation 5", Description = "Next-generation gaming console", Category = "Electronics", Price = 499.00m },
                new Product { Id = 8, Name = "Calvin Klein T-Shirt", Description = "High-quality cotton T-shirt", Category = "Clothing", Price = 20.00m },
                new Product { Id = 9, Name = "Dell Laptop", Description = "High-performance laptop for business", Category = "Electronics", Price = 799.00m },
                new Product { Id = 10, Name = "Reebok CrossFit Shoes", Description = "High-performance cross-training shoes", Category = "Sports", Price = 120.00m },
                new Product { Id = 11, Name = "LG Refrigerator", Description = "High-capacity refrigerator with advanced features", Category = "Home Appliances", Price = 2499.00m },
                new Product { Id = 12, Name = "Under Armour Hoodie", Description = "High-quality athletic hoodie", Category = "Clothing", Price = 40.00m },
                new Product { Id = 13, Name = "Microsoft Office Software", Description = "Productivity software suite", Category = "Software", Price = 149.00m },
                new Product { Id = 14, Name = "Bose Headphones", Description = "High-quality wireless headphones", Category = "Electronics", Price = 299.00m },
                new Product { Id = 15, Name = "Puma Soccer Cleats", Description = "High-performance soccer cleats", Category = "Sports", Price = 150.00m },
                new Product { Id = 16, Name = "Whirlpool Washing Machine", Description = "High-capacity washing machine with advanced features", Category = "Home Appliances", Price = 999.00m },
                new Product { Id = 17, Name = "Ray-Ban Sunglasses", Description = "High-quality sunglasses with polarized lenses", Category = "Accessories", Price = 180.00m },
                new Product { Id = 18, Name = "HP Printer", Description = "High-quality inkjet printer for home use", Category = "Electronics", Price = 99.00m },
                new Product { Id = 19, Name = "The North Face Jacket", Description = "High-quality waterproof jacket for outdoor activities", Category = "Clothing", Price = 120.00m },
                new Product { Id = 20, Name = "Fitbit Smartwatch", Description = "High-performance smartwatch with fitness tracking features", Category = "Electronics", Price = 249.00m }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
