using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        //    public static void Main(string[] args)
        //    {
        //} 
       
        //List product by name
        public static Product FindProduct(List<Product> products, string name)
        {
            Product product = new Product();
            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].name == name)
                {
                    product = products[i];
                }
            }
            return product;
        }
        //list product by category
        public static List<Product> FindProductByCategory(List<Product> products, int Id)
        {
            List<Product> results = new List<Product>();

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].categoryId == Id)
                {
                    results.Add(products[i]);
                }
            }
            return results;
        }
        //list product by price
        public static List<Product> FindProductByPrice(List<Product> products, double price)
        {
            List<Product> results = new List<Product>();
            for (int i = 0; i < products.Count(); i++)
            {
                if(products[i].price <= price)
                {
                    results.Add(products[i]);
                }
            }
            return results;
        }
    }
}
