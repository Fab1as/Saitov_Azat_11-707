using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            sbyte i = 9;
            string divisors = "";
            while (i > 1)
                if (n % i == 0)
                {
                    n /= i;
                    divisors = divisors.Insert(0, $"{i}");
                }
                else i--;
            if (n == 1) Console.WriteLine(divisors);
            else Console.WriteLine(-1);
        }
    }
}
