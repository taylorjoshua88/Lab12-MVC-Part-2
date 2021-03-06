﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieLibrary.Models;

namespace MovieLibrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Movie Library";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Information";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
