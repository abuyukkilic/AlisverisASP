using Abuyukkilic.Mvc.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {

            return View(_context.Products.Where(i=>i.IsApproved == true && i.IsHome == true).ToList());
        }

        public ActionResult Details(int Id)
        {
            return View(_context.Products.Where(i => i.Id == Id).FirstOrDefault());
        }

        public ActionResult List()
        {
            return View(_context.Products.Where(i => i.IsApproved == true).ToList());
        }
    }
}