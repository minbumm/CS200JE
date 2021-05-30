using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A050_A059
{
    class A058_ArrayClass
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 };
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone();
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);
            PrintArray(c);

            a.CopyTo(c, 3);
            PrintArray(c);

            // (3) 오름차순으로 정렬
            Array.Sort(a);
            PrintArray(a);

            // (4) 내림차순으로 정렬
            Array.Reverse(a);
            PrintArray(a);

            // (5) 배열을 초기화
            Array.Clear(a, 0, a.Length);
            PrintArray(a);
        }

        private static void PrintArray(int[] a) 
        {
            foreach (var i in a)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
        }

    }
}
