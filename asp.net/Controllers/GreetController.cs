using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Index(string name)
        {
            ViewData["Name"] = name;
            return View();
        }
    }
}
