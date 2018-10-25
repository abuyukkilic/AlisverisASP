using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abuyukkilic.Mvc.WebUI.Entity;
using Abuyukkilic.Mvc.WebUI.Identity;
using Abuyukkilic.Mvc.WebUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;

        private RoleManager<ApplicationRole> RoleManager;

        private DataContext db = new DataContext();
        [Authorize]
        public ActionResult Index()
        {
            var username = User.Identity.Name;
            var orders = db.Order.Where(i => i.UserName == username).Select(i => new UserOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderState = i.OrderState,
                OrderDate = i.OrderDate,
                Total = i.Total
            }).OrderByDescending(i => i.OrderDate).ToList();
            return View(orders);
        }
        [Authorize]
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

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt işlemleri
                ApplicationUser user = new ApplicationUser
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    UserName = model.Username
                };

                IdentityResult result = UserManager.Create(user, model.Password);
                if (result.Succeeded)
                {
                    //Kullanıcı başarıyla oluşturuldu kullanıcıyı bir role atayabilirsiniz.
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }

                    return RedirectToAction("Login", "Account");

                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı Oluşturma Hatası");
                }
            }

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Login işlemleri
                var user = UserManager.Find(model.Username, model.Password);
                if (user != null)
                {
                    // varolan kullanıcı sisteme dahil et
                    //ApplicationCookie oluştur ve sisteme bırak

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityClaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProporties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };
                    authManager.SignIn(authProporties, identityClaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok");
                }



            }

            return View();
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}