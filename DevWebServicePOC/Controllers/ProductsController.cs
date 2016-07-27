using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevWebServicePOC.Models;
using System.Web.Http;

namespace DevWebServicePOC.Controllers
{
    public class ProductsController : ApiController
    {
        //
        // GET: /Products/
        Product[] Products = new Product[]
        {
    new Product { ProductID = 1, ProductName = "Product 1", ProductCatagory= "Category 1", ProductPrice = 120 },
    new Product { ProductID = 2, ProductName = "Product 2", ProductCatagory= "Category 2", ProductPrice = 200}
        };

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }
        

   //     public ActionResult Index()
    //    {
     //       return View();
      //  }

    }
}
