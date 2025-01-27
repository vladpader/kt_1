using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewData["Message"] = message;
            return View("DisplayMessage");
        }
    }
}
