using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
namespace dotnet_store.Controllers;

    public class CategoryController: Controller
    {
        private readonly DataContext _context;
        public CategoryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.Select(i => new CategoryGetModel
            {
                CategoryName = i.CategoryName,
                Url = i.Url,
                Id = i.Id,
                ProductCount = i.Products.Count()
            }).ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryCreateModel model)
        {

            _context.Categories.Add(new Category
            {
                CategoryName = model.CategoryName,
                Url = model.Url,
            });
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
