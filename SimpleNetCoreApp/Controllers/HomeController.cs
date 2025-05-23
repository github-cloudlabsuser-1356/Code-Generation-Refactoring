using Microsoft.AspNetCore.Mvc;

namespace SimpleNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}