﻿using Microsoft.AspNetCore.Mvc;

namespace Project_Structure.controoler
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
