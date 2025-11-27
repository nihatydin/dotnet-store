namespace dotnet_store.Models;

public class ProductGetModel
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public double Price { get; set; }
    public string? Image { get; set; }
    public bool Active { get; set; }
    public bool isHome { get; set; }
    public string CategoryName { get; set; } = null!;
}