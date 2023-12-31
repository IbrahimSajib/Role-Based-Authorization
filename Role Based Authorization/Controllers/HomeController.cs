using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Role_Based_Authorization.Models;
using System.Diagnostics;

namespace Role_Based_Authorization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Public()
        {
            return View();
        }

        [Authorize]
        public IActionResult Private()
        {
            return View();
        }
        
        [Authorize(Roles ="Admin")]
        public IActionResult Admin_Only()
        {
            return View();
        }
        
        [Authorize(Roles ="Admin,Editor")]
        public IActionResult EditorsPage()
        {
            return View();
        }



        [Authorize]
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
