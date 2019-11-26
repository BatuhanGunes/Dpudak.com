using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dpudak.com.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Boards()
        {
            return View();
        }
        public ActionResult Rules()
        {
            return View();
        }
    }
}