using Microsoft.AspNetCore.Mvc;

public class PageController : Controller
{
    public IActionResult Welcome()
    {
        return View();
    }
}
