using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Threading.Tasks;

namespace learn_asp_dot_net_mvc_bytepp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Default");
        }

        //почему асинхронный метод должен быть?
        [HttpPost]
        public async Task<string> Hello(string name)
        {
            //string userName = await JsonConvert.DeserializeObject<string>(name);

            string userName = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<string>(name));

            //return $"Hello {name}";

            //return string.Format("Hello {0}", name);

            return await Task.Factory.StartNew(() => JsonConvert.SerializeObject(string.Format("Hello {0}", userName)));
        }
    }
}