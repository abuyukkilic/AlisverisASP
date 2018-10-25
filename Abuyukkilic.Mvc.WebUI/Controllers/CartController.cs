using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abuyukkilic.Mvc.WebUI.Entity;
using Abuyukkilic.Mvc.WebUI.Models;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    public class CartController : Controller
    {
        private  DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddtoCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().AddProduct(product,1);
            }

            return RedirectToAction("Index");
        }


        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }

        [Authorize]
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }


        [Authorize]
        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {
            var cart = GetCart();

            if (cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("UrunYokError","Sepetinizde ürün bulunmamaktadır.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //sipariş veri tabanına kayıt edilecek.
                    //cart sıfırla
                    SaveOrder(cart, entity);

                    cart.Clear();
                    return View("Completed");
                }
                else
                {
                    return View(entity);
                }
            }

            return View();
        }


        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z" };
            Random x = new Random();

            var order = new Order();

            order.OrderNumber = abc[x.Next(0, abc.Length)] + x.Next(111, 999999999) + abc[x.Next(0, abc.Length)];
            var result = db.Order.FirstOrDefault(i => i.OrderNumber == order.OrderNumber);
            while (result != null)
            {
                order.OrderNumber = abc[x.Next(0, abc.Length)] + x.Next(111, 999999999) + abc[x.Next(0, abc.Length)];
                result = db.Order.FirstOrDefault(i => i.OrderNumber == order.OrderNumber);
            }


            order.Total = cart.Total();
            order.OrderDate = DateTime.Now;

            order.UserName = entity.UserName;
            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.Orderlines = new List<OrderLine>();
            foreach (var pr in cart.CartLines)
            {
                OrderLine orderline = new OrderLine();
                orderline.Quantity = pr.Quantity;
                orderline.Price = pr.Quantity * pr.Product.Price;
                orderline.ProductId = pr.Product.Id;

                order.Orderlines.Add(orderline);
            }

            db.Order.Add(order);
            db.SaveChanges();

        }
    }
}