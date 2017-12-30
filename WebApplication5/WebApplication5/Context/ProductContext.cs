using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Context
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> product{ get; set; }
        }
}