using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Slider> Sliders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider>()
            {
                new Slider() { Id = 1, Title="First Slider", Description="This is the first slider", Image="slider-1.jpeg", Index=0, isActive=true },
                new Slider() { Id = 2, Title="Second Slider", Description="This is the second slider", Image="slider-2.jpeg", Index=1, isActive=true },
                new Slider() { Id = 3, Title="Third Slider", Description="This is the third slider", Image="slider-3.jpeg", Index=2, isActive=true },
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new List<Category>()
            {
                new Category() { Id = 1, CategoryName="Smart Phone", Url="smart-phone" },
                new Category() { Id = 2, CategoryName="Laptop", Url="laptop" },
                new Category() { Id = 3, CategoryName="Tablet", Url="tablet" },
                new Category() { Id = 4, CategoryName="Smart Watch", Url="smart-watch" },
            }
        );

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() { Id = 1, ProductName="Apple Watch 10", Image="1.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=32000,Active=true,isHome=true,CategoryId=4 },
                new Product() { Id = 2, ProductName="Apple Watch 11", Image="2.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=42000,Active=true,isHome=true,CategoryId=4 },
                new Product() { Id = 3, ProductName="Apple Watch 12", Image="3.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=52000,Active=true,isHome=true,CategoryId=4 },
                new Product() { Id = 4, ProductName="Apple Watch 13", Image="4.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=62000,Active=true,isHome=true,CategoryId=4 },
                new Product() { Id = 5, ProductName="Apple Watch 14", Image="5.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=72000,Active=true,isHome=false,CategoryId=4 },
                new Product() { Id = 6, ProductName="Apple Iphone 15", Image="6.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=82000,Active=false,isHome=false,CategoryId=1 },
                new Product() { Id = 7, ProductName="Apple Iphone 16", Image="7.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=92000,Active=true,isHome=false,CategoryId=1 },
                new Product() { Id = 8, ProductName="Apple Iphone 17", Image="8.jpeg",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptate iusto voluptatem similique cupiditate officiis expedita maxime nihil placeat ad, rem quis tenetur consequuntur quia praesentium odit ex vel id. Asperiores.", Price=102000,Active=true,isHome=false,CategoryId=1 },
            }
        );
    }
}