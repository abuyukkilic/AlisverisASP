using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abuyukkilic.Mvc.WebUI.Entity
{
    public class Contact
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string AdSoyad { get; set; }
        public string Subject { get; set; }
        public string EmailContent { get; set; }
        public DateTime SendingTime { get; set; }
        public bool isSent { get; set; }

    }
}