using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == 1) Console.Write("x^2");
            else if (a != 0) Console.Write($"{a}*x^2");

            if (b < 0) Console.Write($"{b}*x");
            else if (b == 1 && a != 0) Console.Write("+x");
            else if (b == 1 && a == 0) Console.Write('x');
            else if (b > 0 && a != 0) Console.Write($"+{b}*x");
            else if (b > 0 && a == 0) Console.Write($"{b}*x");

            if (c < 0) Console.WriteLine(c);
            else if ((a != 0 || b != 0) && c > 0) Console.WriteLine($"+{c}");
            else if (c > 0) Console.WriteLine(c);
        }
    }
}
