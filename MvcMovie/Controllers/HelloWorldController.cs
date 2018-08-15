using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome
        public ActionResult Welcome(string name, int numTimes = 2)
        {
            //return HttpUtility.HtmlEncode("Hello" + name + ", time is " + clock);
            // gelistirme ilk hali

            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
	}
}