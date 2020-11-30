using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Parent
    {
        [Key]
        public int Parent_id { get; set; }
        public string Name { get; set; }
        public ICollection<Menu> menus { get; set; }
    }
}
