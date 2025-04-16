using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
