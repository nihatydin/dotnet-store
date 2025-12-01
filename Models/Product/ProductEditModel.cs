namespace dotnet_store.Models;

public class ProductEditModel
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public double Price { get; set; }
    public string? ImageName { get; set; }
    public IFormFile? ImageFile { get; set; }
    public string Description { get; set; } = null!;
    public bool Active { get; set; }
    public bool isHome { get; set; }
    public int CategoryId { get; set; }
}