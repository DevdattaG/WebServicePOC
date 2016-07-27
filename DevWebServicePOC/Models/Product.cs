using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevWebServicePOC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCatagory { get; set; }
        public int ProductPrice { get; set; }
    }
}