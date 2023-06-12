using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index() //Veriler listelenirken görüntülenen yer
        {
            return View();
        }

        public ActionResult Test2()
        {
            return View();
        }
    }
}