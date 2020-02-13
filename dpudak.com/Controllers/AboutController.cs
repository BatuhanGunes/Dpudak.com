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
            sad
            return View();
        }
        public ActionResult Rules()
        {
            return View();
        }




        private Model db = new Model();
        public ActionResult ActivityReports()
        {
            using (Model ctx = new Model())
            {
                string param = this.Request.QueryString["Daglar"];
                int x = Convert.ToInt32(param);
                var state = ctx.Daglar.Where(s => s.DagID == x).ToList();

                if (state != null)
                {
                    return View(state);
                }
                else
                {
                    return View();
                }

            }
        }




    }

    internal class Model
    {
        public IEnumerable<object> Daglar { get; internal set; }
    }
}