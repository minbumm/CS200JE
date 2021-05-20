using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A070_A079
{
    class A072_IsLeapYear
    {
        static void Main(string[] args)
        {
            for (int year = 2001; year <= 2100; year++)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("{0} ", year);
                }
                Console.WriteLine();
            }
        }

        private static bool IsLeapYear(int year) 
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);  
        }
    }
}
