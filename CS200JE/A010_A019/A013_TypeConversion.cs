﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A010_A019
{
    class A013_TypeConversion
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;  // 암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.7;
            int a;

            a = (int)x;       // Cast double to int.
            Console.WriteLine(a);
        }
    }
}
