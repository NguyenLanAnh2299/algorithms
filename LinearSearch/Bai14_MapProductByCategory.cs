using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai14_MapProductByCategory
    {
        public static List<Product> MapProductByCategory(List<Product> products, List<Category> categories)
        {
            List<Product> pro = new List<Product>();
            foreach (var category in categories)
            {
                for (int i = 0; i < products.Count(); i++)
                {
                    if (products[i].categoryId == category.Id)
                    {
                        pro.Add(products[i]);
                    }
                }
            }
            return pro;
        }
    }
}
