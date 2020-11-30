using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai21_calSalary
    {
        public static double calSalary(double salary, int n)
        {
            for(int i= 0; i <n; i++)
            {
                salary += salary * 0.1;
            }
            return salary;
        }
        public static double Salary(double salary, int n)
        {
            if(n == 0)
            {
                return salary;
            }
            return Salary(salary, n-1)+ Salary(salary, n - 1)*0.1;
        }
    }
}
