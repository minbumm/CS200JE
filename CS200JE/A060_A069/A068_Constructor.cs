using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A060_A069
{
    class Date1 // A067에 Date 클래스가 있어서 이름 변경
    {
        private int year, month, day;

        public Date1() 
        {
            year = 1;
            month = 1;
            day = 1;         
        }

        public Date1(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }

    class A068_Constructor
    {
        static void Main(string[] args)
        {
            Date1 birthday = new Date1(2000, 11, 22);
            Date1 christmas = new Date1(2018, 12, 25);
            Date1 theDay = new Date1();

            birthday.PrintDate();
            christmas.PrintDate();
            theDay.PrintDate();
        }

    }
}
