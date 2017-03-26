using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WouldYouRatherClone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            ViewBag.Title = "Home Page";
            ViewBag.Id = id == null ? 1 : id;

            return View();
        }
    }
}
