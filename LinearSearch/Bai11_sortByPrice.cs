using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai11_sortByPrice
    {
        public static List<Product> SortByPrice(List<Product> products)
        {
            int i, j;
            Product temp;
            for(i = 0; i < products.Count; i++)
            {
                for(j = 0; j < products.Count -1 -i; j++)
                {
                    if(products[j].price > products[j+1].price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
            return products;
        }
    }
}
