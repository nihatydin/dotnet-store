namespace dotnet_store.Models;

public class CategoryEditModel
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Url { get; set; } = null!;
}