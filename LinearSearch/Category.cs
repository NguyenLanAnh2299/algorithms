﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
