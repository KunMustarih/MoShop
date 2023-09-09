using Microsoft.AspNetCore.Mvc;
using MoShop.Models;
using System.Diagnostics;

namespace MoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET:/Sjirt
        public IActionResult Index()
        {
           
            return View(_context.Shirts.ToList());
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