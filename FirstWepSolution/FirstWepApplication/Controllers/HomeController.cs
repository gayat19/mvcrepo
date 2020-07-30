using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWepApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("Default")]
        public ActionResult Landing()
        {
            return View();
        }


        public ActionResult Another()
        {
            return View();
        }

    }
}