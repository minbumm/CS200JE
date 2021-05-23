﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A070_A079
{
    class A079_RecursivePower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Povwe(x,y)를 계산합니다.");
            Console.Write(" x를 입력하세요!: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" y를 입력하세요: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(" {0}^{1} = {2}", x, y, Power(x, y));

        }


        private static double Power(double x, double y) 
        {
            if (y == 0)
            {
                return 1;
            }
            else 
            {
                return x * Power(x, y - 1);
            }
        }
    }
}
