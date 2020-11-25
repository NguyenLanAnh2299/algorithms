using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Product
    {
            public string name { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
            public int categoryId { get; set; }
            public virtual Category Category { get; set; }

        public static implicit operator Product(char v)
        {
            throw new NotImplementedException();
        }
    }
}
