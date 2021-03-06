﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abuyukkilic.Mvc.WebUI.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Contact> Contact { get; set; }

    }
}