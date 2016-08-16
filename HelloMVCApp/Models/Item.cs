using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVCApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName  { get; set; }
        public decimal UnitPrice { get; set; }
    }
}