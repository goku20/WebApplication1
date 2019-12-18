using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ReviewList = Review.reviewsList; 
             



            return View();

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string info)
        {
            if (string.IsNullOrWhiteSpace(info))
            {
                ViewBag.Msg = "You must enter some text.";
                return View();
            }
            else
            {
                Review.reviewsList.Add(new Review() { Info = info });
                return RedirectToAction("index");
            }


           
        }
    }

}