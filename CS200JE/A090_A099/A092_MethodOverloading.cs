﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A090_A099
{
    class A092_MethodOverloading
    {
        static void Main(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("SUM = ", 123.4);
        }

        private static void Print(double x)
        {
            Console.WriteLine(x);
        }

        private static void Print(string s, double x) 
        {
            Console.WriteLine(s+ x);
        }

        private static void Print(int x) 
        {
            Console.WriteLine(x);
        }


    }




}
