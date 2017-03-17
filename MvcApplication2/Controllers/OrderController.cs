using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
         
            var order = orderService.GetOrderByid("11111");
            ViewBag.CustomerID = order.CustomerID;
            ViewBag.ShipCity = order.ShipCity;
            return View();
        }

    }
}
