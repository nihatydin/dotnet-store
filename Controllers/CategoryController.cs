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
            var categories = _context.Categories.ToList();
            return View(categories);
        }
    }
