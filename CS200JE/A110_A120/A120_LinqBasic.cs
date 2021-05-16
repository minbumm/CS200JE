using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A110_A120
{
    class A120_LinqBasic
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lstSortedEven = new List<int>();

            foreach (var item in data)
            {
                if (item % 2 == 0)
                {
                    lstSortedEven.Add(item);
                }
            }
            lstSortedEven.Sort();

            Console.WriteLine("Using foreach");
            foreach (var item in lstSortedEven)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

    }
}
