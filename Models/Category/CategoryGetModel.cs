namespace dotnet_store.Models;

 class CategoryGetModel
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Url { get; set; } = null!;
    public int ProductCount { get; set; }
}