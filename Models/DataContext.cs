using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() { Id = 1, ProductName="Apple Iphone 12", Price=32000,Active=true },
                new Product() { Id = 2, ProductName="Apple Iphone 13", Price=42000,Active=false },
                new Product() { Id = 3, ProductName="Apple Iphone 14", Price=52000,Active=true },
                new Product() { Id = 4, ProductName="Apple Iphone 15", Price=62000,Active=true },
                new Product() { Id = 5, ProductName="Apple Iphone 16", Price=72000,Active=true },
                new Product() { Id = 6, ProductName="Apple Iphone 17", Price=82000,Active=false },
            }
        );
    }
}