using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Areas.Emp.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Emp/Default1/

        public ActionResult Index()
        {
            ViewBag.emp = "Hello Emp";
            return View();
        }

    }
}
