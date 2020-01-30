using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelthController : Controller
    {

        public ActionResult FeverCheck()
        {
            return View();
        }
        public ActionResult CompareTemp(double? newNumber, string Temperature)
        {

            if (newNumber == null)
            {
                ViewBag.Message = "Your result will show up here.";

            }


            if (Temperature.Equals("Celsius"))
            {
                if (newNumber > 37.7)
                {
                    ViewBag.Message = "You have a fever go the bed!";
                }
                else if (newNumber < 35)
                {
                    ViewBag.Message = "You have hypothermia !";
                }
                else
                {
                    ViewBag.Message = "You are just fine";
                }
            }
            else
            {
                if (newNumber > 99.86)
                {
                    ViewBag.Message = "You have a fever !";
                }
                else if (newNumber < 95)
                {
                    ViewBag.Message = "You have hypothermia !";
                }
                else
                {
                    ViewBag.Message = "You are just fine";
                }
            }
            return View("FeverCheck");
        }

    }

}
