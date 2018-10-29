using Abuyukkilic.Mvc.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Abuyukkilic.Mvc.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private DataContext db = new DataContext();
  

        public ActionResult Iletisim()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //[Bind(Include = "Id,EmailAddress,AdSoyad,Subject,EmailContent,AcceptSendEmail")] 
        public ActionResult Iletisim(Contact contact)
        {

            if (ModelState.IsValid)
            {
                contact.SendingTime = DateTime.Now.ToLocalTime();


                string server = ConfigurationManager.AppSettings["server"];
                int port = int.Parse(ConfigurationManager.AppSettings["port"]);
                bool ssl = ConfigurationManager.AppSettings["ssl"].ToString() == "1" ? true : false;

                string from = ConfigurationManager.AppSettings["frommail"];
                string password = ConfigurationManager.AppSettings["password"];
                string fromname = ConfigurationManager.AppSettings["fromname"];
                string to = ConfigurationManager.AppSettings["to"];
                string copyto = ConfigurationManager.AppSettings["epostacopy"];

                var client = new SmtpClient();
                client.Host = server;
                client.Port = port;
                client.EnableSsl = ssl;
                client.UseDefaultCredentials = true;
                client.Credentials = new System.Net.NetworkCredential(from,password);

                var email = new MailMessage();
                email.From = new MailAddress(from,fromname);
                email.To.Add(to);
                if (!string.IsNullOrEmpty(copyto))
                {
                    string [] mails = copyto.Split(',');
                    foreach (var item in mails)
                    {
                        email.Bcc.Add(item);
                    }                    
                }

                email.Subject = contact.Subject;
                email.IsBodyHtml = true;
                email.Body = $"ad soyad: {contact.AdSoyad} \n" +
                             $"konu: {contact.Subject}\n" +
                             $"gönderim zamanı: {contact.SendingTime} \n" +
                             $"mail içeriği : {contact.Subject}";
                try
                {
                    client.Send(email);
                    ViewData["result"] = true;
                    contact.isSent = true;
                }
                catch (Exception e)
                {
                    ViewData["result"] = false;
                    contact.isSent = false;
                    Console.WriteLine(e);
                    throw;
                }


                
                db.Contact.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Iletisim");
            }        
            return View(contact);
        }
    }

    
}