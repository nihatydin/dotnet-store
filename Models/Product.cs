namespace dotnet_store.Models;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public double Price { get; set; }
    public string? Image { get; set; }
    public string? Description { get; set; }
    public bool Active { get; set; }
    public bool isHome { get; set; }
}