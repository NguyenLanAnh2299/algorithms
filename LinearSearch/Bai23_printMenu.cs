using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Bai23_printMenu
    {
        public static void printMenu (List<Menu> menus)
        {
            for (int i =0; i < menus.Count(); i++)
            {    
                if(menus[i].Parent_id == 0)
                {
                    Console.WriteLine(menus[i].Title);
                    for(int j=0; j < menus.Count(); j++)
                    {
                        if(menus[j].Parent_id == menus[j].Id)
                        {
                            Console.WriteLine("--" + menus[j].Title);
                        }
                    }
                }
            }
        }

    }
}
