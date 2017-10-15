using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            const sbyte n = 100;
            Console.WriteLine((n * (n + 1) * (2 * n + 1)) / 6 - (((1 + n) * n) / 2) * (((1 + n) * n) / 2));
            //long sum2 = 0, ksum = 0;
            //for (int i=1;i<=100;i++)
            //{
            //    sum2 += i * i;
            //    ksum += i;
            //}
            //Console.WriteLine(sum2 - ksum*ksum);
        }
    }
}
