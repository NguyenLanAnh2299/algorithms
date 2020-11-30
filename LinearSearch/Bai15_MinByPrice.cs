using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai15_MinByPrice
    {
        public static List<Product> ProductMin(List<Product> products)
        {
            Product proMin = products[0];
            foreach(var product in products)
            {
                if(proMin.price > product.price)
                {
                    proMin = product;
                }
            }
            return products;
        }
    }
}
