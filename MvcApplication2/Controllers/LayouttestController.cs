using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class LayouttestController : Controller
    {
        //
        // GET: /Layouttest/
        /// <summary>
        /// 測試主版頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

    }
}
