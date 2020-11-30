using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Parent_id { get; set; }
        public virtual Parent Parent { get; set; }
    }
}
