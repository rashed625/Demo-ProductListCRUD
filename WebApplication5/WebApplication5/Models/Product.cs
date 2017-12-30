using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Product Name")]
        public string   ProductName { get; set; }
        public string  Quantity { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}