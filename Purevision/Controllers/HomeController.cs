using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purevision.Web.DataContexts;
using Purevision.Web.Helpers;

namespace Purevision.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.HostName = System.Net.Dns.GetHostName();
            ViewBag.ConnectionStringName = ConnectionStringHelpers.GetHostBasedConnectiongStringName();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}