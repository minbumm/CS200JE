using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS200JE.A010_A019
{
    class A019_Overflow
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(double.MaxValue);

            //int x = 10, y = 0;

            //try
            //{
            //Console.WriteLine((double)x / y);
            //Console.WriteLine(x / y);
            //}
            //catch (Exception e)
            //{
            //  Console.WriteLine(e.Message);
            //}

            //Console.Read();

            //Console.WriteLine("int.MaxValue = {0}", int.MaxValue);



            // y = int.MaxValue + 10;  // 이 문장은 컴파일시에 에러가 나옵니다.

            int x = int.MaxValue, y = 0;

            checked
            {
                    
            }
        }
    }
}
