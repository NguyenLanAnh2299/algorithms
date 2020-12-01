using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai13_sortByCategoryName
    {
        public static List<Product> MapProductByCategory(List<Product> products, List<Category> categories)
        {
            Product temp;
            int i, j;
            for (i = 0; i < products.Count() - 1; i++)
            {
                int position = i;
                for (j = i + 1; j < products.Count(); j++)
                {
                    if (categories[j].name.CompareTo(categories[j].name) > categories[j + 1].name.CompareTo(categories[j].name))
                    {
                        position = j;
                    }
                    if (position != i)
                    {
                        temp = products[position];
                        products[position] = products[i];
                        products[i] = temp;
                    }

                }
            }
            return products;
        }
        public static string GetCategoryName(Product product, List<Category> categories)
        {
            string categoryName = "";
            for (int i = 0; i < categories.Count(); i++)
            {
                if (product.categoryId == categories[i].Id)
                {
                    categoryName = categories[i].name;
                    product.name = categories[i].name;
                    break;
                }
            }
            return categoryName;
        }
    }
}

