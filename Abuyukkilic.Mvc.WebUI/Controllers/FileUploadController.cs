using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    public class FileUploadController : Controller
    {
        [HttpGet]
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, int productid)
        {


            if (file != null && file.ContentLength > 0)
            {

                var extensition = Path.GetExtension(file.FileName);

                if (extensition == ".jpg" || extensition == ".png")
                {

                    var folder = Server.MapPath("~/Uploads");
                    var randomFileName = Path.GetRandomFileName(); //rasgele dosya adı
                    var filename = Path.ChangeExtension(randomFileName, ".jpg");
                    var path = Path.Combine(folder, filename);

                    file.SaveAs(path);
                    ViewData["successMessage"] = "Dosya başarıyla yüklenmiştir.";
                }
                else
                {
                    ViewData["errorMessage"] = "Sadece resim dosyalarını upload edebilirsiniz. (png,jpg)";
                }


            }
            else
            {
                ViewData["errorMessage"] = "Bir dosya seçiniz";
            }

            return View();
        }

        [HttpGet]
        public ActionResult AjaxFileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxFileUpload(HttpPostedFileBase[] files, int productid)
        {
            for (int i = 0; i < files.Length; i++)
            {

                var extensition = Path.GetExtension(files[i].FileName);


                var folder = Server.MapPath("~/Uploads");
                var randomFileName = Path.GetRandomFileName(); //rasgele dosya adı
                var filename = Path.ChangeExtension(randomFileName, ".jpg");
                var path = Path.Combine(folder, filename);
                files[i].SaveAs(path);


            }


            return Json("");
        }
    }
}