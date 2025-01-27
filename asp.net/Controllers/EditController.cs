using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string message)
        {
            ViewData["Message"] = message;
            return View("DisplayMessage");
        }
    }
}
