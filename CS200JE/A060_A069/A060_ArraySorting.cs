using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A060_A069
{
    class A060_ArraySorting
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sor: ", name);

            Array.Sort(name);
            PrintArray("After Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
        }


        private static void PrintArray(string s, string[] name) 
        {
            Console.WriteLine(s);
            foreach (var n in name)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine();

        }
    }
}
