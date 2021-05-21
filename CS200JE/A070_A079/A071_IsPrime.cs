﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A070_A079
{
    class A071_IsPrime
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("{0}, ", i);
                    count++;
                }
            }
            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 있습니다.", count);
        }

        private static bool IsPrime(int x) 
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
