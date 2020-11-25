using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Bai13_sortByCategoryName
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
                    for (int j = 0; j < categories.Count(); j++)
                    {
                        for (int k = 0; k < categories.Count() - 1; k++)
                        {
                            if (categories[k].name.CompareTo(categories[k].name) > categories[k + 1].name.CompareTo(categories[k].name))
                            {
                                categories[k] = categories[k + 1];
                            }
                        }
                    }
                }
            }
            return pro;
        }
    }
}

