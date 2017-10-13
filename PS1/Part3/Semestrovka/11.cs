using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestrovka
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte k = 0;
            int max, min, n = 1;
            if (k == 0)
            {
                n = int.Parse(Console.ReadLine());
                k = 1;
            }
            max = n;
            min = n;
            if (k != 0)
            while (n != 0)
            {
                    n = int.Parse(Console.ReadLine());
                    if (n > max) max = n;
                    if (n < min) min = n; 
            }
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
        }
    }
}
