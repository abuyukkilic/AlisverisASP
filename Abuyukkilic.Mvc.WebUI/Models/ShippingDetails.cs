using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abuyukkilic.Mvc.WebUI.Models
{
    public class ShippingDetails
    {
        [DisplayName("Ad Soyad")]
        public string UserName { get; set; }

        [DisplayName("Adres Başlığı")]
        [Required(ErrorMessage = "Lütfen adres tanımını giriniz!")]
        public string AdresBasligi { get; set; }


        [DisplayName("Adres")]
        [Required(ErrorMessage = "Lütfen adresinizi giriniz!")]
        public string Adres { get; set; }

        [DisplayName("Şehir")]
        [Required(ErrorMessage = "Lütfen şehir giriniz!")]
        public string Sehir { get; set; }


        [Required(ErrorMessage = "Lütfen semt giriniz!")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle giriniz!")]
        public string Mahalle { get; set; }

        [DisplayName("Posta Kodu")]
        public string PostaKodu { get; set; }

    }
}