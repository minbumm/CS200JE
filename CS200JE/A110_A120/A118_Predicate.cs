using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A110_A120
{
    class A118_Predicate
    {
        static bool IsEven(int n) => n % 2 == 0;
        static bool IsLowerCase(string s) => s.Equals(s.ToLower());

        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));

            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is a lowercase string"));
        }

    }
}
