﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MathTable()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult FeverCheck()
        {
            return View();
        }
    }



}