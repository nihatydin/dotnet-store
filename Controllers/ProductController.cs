using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class ProductController : Controller
{

    private readonly DataContext _context;
    public ProductController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var products = _context.Products.Select(p=> new ProductGetModel
        {
            Id = p.Id,
            ProductName = p.ProductName,
            Price = p.Price,
            Image = p.Image,
            Active = p.Active,
            isHome = p.isHome,
            CategoryName = p.Category.CategoryName
        }).ToList();

        return View(products);
    }

    // Active products by category
    public ActionResult List(string url, string q)
    {
        // get active products
        var searchResults = _context.Products.Where(p => p.Active);
        
        // filter by category url
        if(!string.IsNullOrEmpty(url))
        {
            searchResults = searchResults.Where(p => p.Category.Url == url);
        }
        // search by query
        if (!string.IsNullOrEmpty(q))
        { 
            searchResults = searchResults.Where(p=> p.ProductName.ToLower().Contains(q.ToLower()) || p.Description.Contains(q));
            ViewData["SearchQuery"] = q;
        }

        return View(searchResults.ToList());
    }
    public ActionResult Details(int id)
    {
        //var product = _context.Products.Find(id); this will return even inactive products
        var product = _context.Products.FirstOrDefault(p => p.Id == id && p.Active);
        if (product == null)
        {
            return NotFound();
        }
        // filter similar products by category, exclude current product, take 4
        ViewData["SimilarProducts"] = _context.Products.Where(p=> p.CategoryId == product.CategoryId && p.Id != product.Id && p.Active).Take(4).ToList();

        return View(product);
    }
}