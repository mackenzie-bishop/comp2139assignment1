using Microsoft.AspNetCore.Mvc;
using SmartInventory.Models;
using System.Collections.Generic;

namespace SmartInventory.Controllers
{
    [Route("Order")] 
    public class OrderController : Controller
    {
        private static List<Order> orders = new List<Order>();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(orders); 
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost("Create")]
        public IActionResult Create(Order order)
        {
            orders.Add(order); 
            return RedirectToAction("Index"); 
        }
    }
}
