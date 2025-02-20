using Microsoft.AspNetCore.Mvc;
using SmartInventory.Models;
using System.Linq;

namespace SmartInventory.Controllers
{
    [Route("ProductCategory")]
    public class ProductCategoryController : Controller
    {
        private readonly SmartInventoryContext _context;

        public ProductCategoryController(SmartInventoryContext context)
        {
            _context = context;
        }

        
        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Manage");
        }

        
        [HttpGet("Manage")]
        public IActionResult Manage()
        {
            var products = _context.Products.ToList();
            var categories = _context.Categories.ToList();

            var model = new ProductCategoryViewModel
            {
                Products = products,
                Categories = categories
            };

            return View("Manage", model);
        }

        
        [HttpGet("AddProduct")]
        public IActionResult AddProduct()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

       
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Manage");
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(product);
        }

       
        [HttpGet("AddCategory")]
        public IActionResult AddCategory()
        {
            return View();
        }

        
        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Manage");
            }

            return View(category);
        }
    }
}
