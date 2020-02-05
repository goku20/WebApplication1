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
        public ActionResult CompareTemp(float? newNumber, string Temperature)
        {
            //if (string.IsNullOrWhiteSpace(Temperature)
                
            //    || newNumber == null
            //    )
            //{
            //    return null;
            //}
            if (newNumber == null)
            {
                ViewBag.Message = "Your must enter digit in Celsius or Farenheit";

            }


            if (Temperature.Equals("Celsius"))
            {

                if (newNumber == null)
                {
                    ViewBag.Message = "Your must enter digit in Celsius or Farenheit";

                }
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
                    ViewBag.Message = "Please enter your temp in Celsius";
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
                    ViewBag.Message = "Enter temp in Farenheit";
                }
            }
            return View("FeverCheck");
        }

    }

}
