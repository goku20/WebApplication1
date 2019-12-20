using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SessionsController : Controller
    {
        public IActionResult LookAt() //skap add veiws enty  hörklicka sen mmm..
        {
            //HttpContex.Items på doc.mocrosoft.com

            ViewBag.Msg = HttpContext.Session.GetString("KeyName");

            return View();
        }
        public IActionResult SaveSession(string message)
        {
             HttpContext.Session.SetString("KeyName" , message);
            return RedirectToAction("LookAt");
        }

    }
}