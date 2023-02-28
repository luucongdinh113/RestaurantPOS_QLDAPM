using Microsoft.AspNetCore.Mvc;
using RestaurantPOS.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace RestaurantPOS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<Object> Index(int x)
        {
            if(x==0) return Enumerable.Empty<Object>();
            return new List<Object>() { new { name = "dinh", age = 18 }, new { name = "hang", age = 20 } };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}