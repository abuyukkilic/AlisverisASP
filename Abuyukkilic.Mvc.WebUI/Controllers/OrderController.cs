using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abuyukkilic.Mvc.WebUI.Entity;
using Abuyukkilic.Mvc.WebUI.Models;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();

        // GET: Order
        public ActionResult Index()
        {
            var orders = db.Order.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                Total = i.Total,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Count = i.Orderlines.Count
            }).OrderByDescending(i => i.OrderDate).ToList();
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            return View()
        }
    }
    
}