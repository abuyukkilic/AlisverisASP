using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abuyukkilic.Mvc.WebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ücret")]
        public double Price { get; set; }
        [DisplayName("Stok Durumu")]
        public int Stock { get; set; }
        [DisplayName("Fotoğraf Linki")]
        public string Image { get; set; }
        [DisplayName("Onaylı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Anasayfa'da Gösterilsin mi?")]
        public bool IsHome { get; set; }



        [DisplayName("Kategori Id?")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}