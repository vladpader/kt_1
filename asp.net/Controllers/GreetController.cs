﻿using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Greet(string id)
        {
            ViewData["Name"] = id;
            return View();
        }
    }
}
