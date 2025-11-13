using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

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
        return View();
    }

    // Active products by category
    public ActionResult List(string url)
    {
        var products = _context.Products.Where(p => p.Active && p.Category.Url == url).ToList();
        return View(products);
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