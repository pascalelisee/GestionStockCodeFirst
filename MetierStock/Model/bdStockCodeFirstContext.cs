using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MetierStock.Model
{
    public class bdStockCodeFirstContext:DbContext
    {
        public bdStockCodeFirstContext() : base("connStock")
        {}
        public DbSet<Categorie> Categories { get; set; }
    }
}