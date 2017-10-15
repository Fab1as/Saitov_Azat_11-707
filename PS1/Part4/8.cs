using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, s = 0;
            for (int i = 1000;i <= 9999; i++)
            {
                num1 = i / 1000;
                num2 = (i / 100) % 10;
                num3 = (i / 10) % 10;
                num4 = i % 10;
                if (Math.Pow(num1, 4) + Math.Pow(num2, 4) + Math.Pow(num3, 4) + Math.Pow(num4, 4) == i)
                    s += i;
            }
            Console.WriteLine(s);
        }
    }
}
