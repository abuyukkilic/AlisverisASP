using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public ActionResult Login(Login model,string ReturnUrl)
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