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
        static IProductsRepository Products = new ProductsRepository();

        public IEnumerable<Product> GetProducts()
        {
            return Products.GetProducts() ;
        }
        public Product GetProduct(int ProductID)
        {
            return Products.Get(ProductID);
        }
        

   //     public ActionResult Index()
    //    {
     //       return View();
      //  }

    }
}
