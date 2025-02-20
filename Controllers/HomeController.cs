using Microsoft.AspNetCore.Mvc;
using SmartInventory.Models;
using System.Linq;

namespace SmartInventory.Controllers
{
    public class HomeController : Controller
    {
        private readonly SmartInventoryContext _context;

        public HomeController(SmartInventoryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products); 
        }

        
        public IActionResult Privacy()
        {
            return View(); 
        }
    }
}
