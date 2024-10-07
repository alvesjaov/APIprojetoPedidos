using Microsoft.AspNetCore.Mvc;

namespace ProjetoPedidos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}