using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Bai22_callMonth
    {
        public static double callMoney(double money, float rate)
        {
            int month;
            double money_rate = money * 2;
            while (money < money_rate)
            {
                money += money * rate;
            }
            return money;
        }
        public static int callMonth(double money, float rate)
        {
            int month;
            double money_rate = money * 2;
            for (month = 1; ; month++)
            {
                if (Month(money, rate, month) >= money_rate)
                {
                    break;
                }
            }
            return month;
        }
        public static double Month(double rate,double money, int month)
        {
            if (month == 0)
            {
                return money;
            }
            return Month(money, rate, month -1 ) + Month(money, rate, month - 1) * rate;
        }
    }
}
