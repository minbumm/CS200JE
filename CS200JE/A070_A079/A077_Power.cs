using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A070_A079
{
    class A077_Power
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("0, 2} = {1, 7}", i, Power(2,1));
            }
        }

        private static int Power(int m, int n) 
        {
            int p = 1;
            for (int i = 1; i <= m; i++)
            {
                p *= n;
            }
            return p;
        }
    }
}
