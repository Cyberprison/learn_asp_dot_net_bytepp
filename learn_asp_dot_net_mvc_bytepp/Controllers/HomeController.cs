using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learn_asp_dot_net_mvc_bytepp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Default");
        }

        [HttpPost]
        public string Hello(string name)
        {
            return $"Hello {name}";

            //return string.Format("Hello {0}", name);
        }
    }
}