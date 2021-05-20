using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A070_A079
{
    class A074_PrymidMethod
    {
        static void Main(string[] args)
        {
            DrawPrymid(3);
            DrawPrymid(5);
            DrawPrymid(7);
        }


        static void DrawPrymid(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int k = 1; k <= 2 * i -1; k++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
