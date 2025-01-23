using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
