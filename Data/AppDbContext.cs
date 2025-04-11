using Microsoft.EntityFrameworkCore;
using ProductListApp.Models;

namespace ProductListApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Seed data
    modelBuilder.Entity<Product>().HasData(
        new Product { 
            Id = 1, 
            Name = "Gradient Graphic T-shirt", 
            Price = 145m, 
            ImageUrl = "/images/gradient-tshirt.jpg", 
            Description = "Graphic t-shirt with colorful rainbow pattern", 
            Quantity = 25, 
            Rating = 3.9, 
            RatingCount = 5
        },
        new Product { 
            Id = 2, 
            Name = "Polo with Tipping Details", 
            Price = 180m, 
            ImageUrl = "/images/polo-tipping.jpg", 
            Description = "Classic polo shirt with contrast tipping", 
            Quantity = 30, 
            Rating = 4.5, 
            RatingCount = 6
        },
        new Product { 
            Id = 3, 
            Name = "Black Striped T-shirt", 
            Price = 120m, 
            OriginalPrice = 160m, 
            ImageUrl = "/images/black-striped-tshirt.jpg", 
            Description = "Striped t-shirt with raglan sleeves", 
            Quantity = 20, 
            Rating = 5.0, 
            RatingCount = 7
        },
        new Product { 
            Id = 4, 
            Name = "Skinny Fit Jeans", 
            Price = 240m, 
            OriginalPrice = 260m, 
            ImageUrl = "/images/skinny-jeans.jpg", 
            Description = "Skinny fit stretch denim jeans", 
            Quantity = 15, 
            Rating = 3.5, 
            RatingCount = 5
        },
        new Product { 
            Id = 5, 
            Name = "Checkered Shirt", 
            Price = 180m, 
            ImageUrl = "/images/checkered-shirt.jpg", 
            Description = "Classic checkered pattern long sleeve shirt", 
            Quantity = 18, 
            Rating = 4.6, 
            RatingCount = 7
        },
        new Product { 
            Id = 6, 
            Name = "Sleeve Striped T-shirt", 
            Price = 130m, 
            OriginalPrice = 160m, 
            ImageUrl = "/images/sleeve-striped-tshirt.jpg", 
            Description = "Orange striped t-shirt with contrast sleeves", 
            Quantity = 22, 
            Rating = 4.5, 
            RatingCount = 6
        },
        new Product { 
            Id = 7, 
            Name = "Vertical Striped Shirt", 
            Price = 212m, 
            OriginalPrice = 232m, 
            ImageUrl = "/images/vertical-striped-shirt.jpg", 
            Description = "Vertical striped long sleeve button-up shirt", 
            Quantity = 12, 
            Rating = 5.0, 
            RatingCount = 8
        },
        new Product { 
            Id = 8, 
            Name = "Courage Graphic T-shirt", 
            Price = 145m, 
            ImageUrl = "/images/courage-tshirt.jpg", 
            Description = "Orange graphic t-shirt with printed design", 
            Quantity = 20, 
            Rating = 4.0, 
            RatingCount = 5
        },
        new Product { 
            Id = 9, 
            Name = "Loose Fit Bermuda Shorts", 
            Price = 80m, 
            ImageUrl = "/images/bermuda-shorts.jpg", 
            Description = "Classic denim bermuda shorts", 
            Quantity = 25, 
            Rating = 3.0, 
            RatingCount = 5
        }
    );
}
    }
}