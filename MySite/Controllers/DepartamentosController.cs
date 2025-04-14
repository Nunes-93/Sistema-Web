using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();

            list.Add(new Departamento { Id = 1, Nome = "Fashion" });
            list.Add(new Departamento { Id = 2, Nome = "Eletrônico" });

            return View(list);
        }
    }
}
