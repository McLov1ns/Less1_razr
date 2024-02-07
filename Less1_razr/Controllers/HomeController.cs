using Microsoft.AspNetCore.Mvc;

namespace Less1_razr.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Short() 
        { 
            return View();
        }
    }
}
