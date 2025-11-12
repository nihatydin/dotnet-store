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
                new Product() { Id = 1, ProductName="Apple Iphone 10", Image="1.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=32000,Active=true },
                new Product() { Id = 2, ProductName="Apple Iphone 11", Image="2.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=42000,Active=true },
                new Product() { Id = 3, ProductName="Apple Iphone 12", Image="3.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=52000,Active=true },
                new Product() { Id = 4, ProductName="Apple Iphone 13", Image="4.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=62000,Active=true },
                new Product() { Id = 5, ProductName="Apple Iphone 14", Image="5.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=72000,Active=true },
                new Product() { Id = 6, ProductName="Apple Iphone 15", Image="6.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=82000,Active=false },
                new Product() { Id = 7, ProductName="Apple Iphone 16", Image="7.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=92000,Active=true },
                new Product() { Id = 8, ProductName="Apple Iphone 17", Image="8.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=102000,Active=true },
            }
        );
    }
}