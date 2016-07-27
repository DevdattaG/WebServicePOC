using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevWebServicePOC.Models
{
    interface IProductsRepository
    {
        IEnumerable<Product> GetProducts();
        Product Get(int ProductID);
    }
}
