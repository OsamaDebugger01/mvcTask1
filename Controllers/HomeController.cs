﻿using Microsoft.AspNetCore.Mvc;

namespace mvcLab1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("home");
        }
    }
}
