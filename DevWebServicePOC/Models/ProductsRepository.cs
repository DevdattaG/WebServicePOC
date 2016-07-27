using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevWebServicePOC.Models
{
    public class ProductsRepository : IProductsRepository
    {
        Product[] Products = new Product[]
        {
    new Product { ProductID = 1, ProductName = "Lenovo K4 Note", ProductCatagory= "Mobiles", ProductPrice = 12000 },
    new Product { ProductID = 2, ProductName = "Skullcandy Ink'D 60070D", ProductCatagory= "Headsets", ProductPrice = 650},
    new Product { ProductID = 3, ProductName = "Sennheiser Street 150", ProductCatagory= "Headsets", ProductPrice = 900},
    new Product { ProductID = 4, ProductName = "Dell Inspiron N5110", ProductCatagory= "Laptops", ProductPrice = 44500}
        };


        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }

        public Product Get(int ProductID)
        {
            return Products[ProductID];
        }
    }
}