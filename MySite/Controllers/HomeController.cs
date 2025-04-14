using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers
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
            ViewData["Contato"] = "(75) 98232-5189";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Email"] = "nunes@email.com";
            ViewData["Nome"] = "Matheus Nunes Menezes";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
