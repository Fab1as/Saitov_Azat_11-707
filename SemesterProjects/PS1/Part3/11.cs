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
            int max, min, n = 1;
                n = int.Parse(Console.ReadLine());
            max = n;
            min = n;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                else if (n > max) max = n;
                else if (n < min) min = n; 
            }
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
        }
    }
}
