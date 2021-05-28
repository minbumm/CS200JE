using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A050_A059
{
    class A054_TimesTable
    {
        static void Main(string[] args)
        {
            for (int y = 1; y <= 9; y++)
            {
                for (int i = 2; i <= 9; y++)
                {
                    for (int x = 2; x <= 9; x++)
                    {
                        Console.WriteLine("{0}x{1}={2,2} ",x, y, x*y);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
