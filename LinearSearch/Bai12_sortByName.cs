using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Bai12_sortByName
    {
        public static List<Product> SortByName(List<Product> products)
        {
            Product temp;
            int holePostion;
            for(int i = 0; i< products.Count; i++)
            {
                holePostion = 1;
                temp = products[i];
                while (holePostion > 0 && products[holePostion -1 ].name.Length > temp.name.Length)
                {
                    products[holePostion] = products[holePostion - 1];
                    holePostion--;
                }
                if(holePostion != i)
                {
                    products[holePostion] = temp;
                }
            }
            return products;
        }
    }
}
