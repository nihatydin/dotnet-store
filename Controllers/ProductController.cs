using System.Threading.Tasks;
using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
    public ActionResult Create()
    {

        ViewBag.Categories = _context.Categories.ToList();

        return View();
    }


    [HttpPost]
    public async Task<ActionResult> Create(ProductCreateModel model)
    {
        var fileName = Path.GetRandomFileName() + ".jpeg";
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", fileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await model.Image!.CopyToAsync(stream);
        }

        var product = new Product
        {
            ProductName = model.ProductName,
            Price = model.Price,
            Description = model.Description,
            isHome = model.isHome,
            Active = model.Active,
            CategoryId = model.CategoryId,
            Image = fileName
        };
        _context.Products.Add(product);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
        var entity = _context.Products.Select(i=> new ProductEditModel
        {
            Id = i.Id,
            ProductName = i.ProductName,
            Price = i.Price,
            Description = i.Description,
            isHome = i.isHome,
            Active = i.Active,
            CategoryId = i.CategoryId,
            ImageName = i.Image
        }).FirstOrDefault(p=> p.Id == id);

        ViewBag.Categories = _context.Categories.ToList();

        return View(entity);
    }
    [HttpPost]
    public async Task<ActionResult> Edit(int id, ProductEditModel model)
    {
        if(id != model.Id)
        {
            RedirectToAction("Index");
        }

        var entity = _context.Products.FirstOrDefault(p => p.Id == id);

        

        if (entity != null)
        {

            if (model.ImageFile != null)
            {
                var fileName = Path.GetRandomFileName() + ".jpeg";
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.ImageFile!.CopyToAsync(stream);
                }
                entity.Image = fileName;
            }

            entity.ProductName = model.ProductName;
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.isHome = model.isHome;
            entity.Active = model.Active;
            entity.CategoryId = model.CategoryId;

            _context.SaveChanges();

            TempData["Success"] = $"{entity.ProductName} has been updated successfully.";

            return RedirectToAction("Index");
        }

        return View(model);
    }

}