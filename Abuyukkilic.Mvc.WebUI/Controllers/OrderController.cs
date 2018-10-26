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
            var entity = db.Order.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    Adres = i.Adres,
                    AdresBasligi = i.AdresBasligi,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    PostaKodu = i.PostaKodu,
                    Mahalle = i.Mahalle,
                    Username = i.UserName,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + ".." : a.Product.Name,
                        Image = a.Product.Image,
                        Price = a.Price,
                        Quantity = a.Quantity
                    }).ToList()

                }).FirstOrDefault();

            return View(entity);
        }

        public ActionResult UpdateOrderState(int OrderId, EnumOrderState OrderState)
        {
            var order = db.Order.FirstOrDefault(i => i.Id == OrderId);
            if (order != null)
            {
                order.OrderState = OrderState;
                db.SaveChanges();
                TempData["message"] = "Bilgileriniz kaydedildi";
                return RedirectToAction("Details", new {id = order.Id});
            }

            return RedirectToAction("Index"); 
        }
    }
    
}