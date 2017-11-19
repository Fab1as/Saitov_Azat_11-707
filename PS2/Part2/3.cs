using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("CompPI = " + Math.PI);
            Console.WriteLine("ProgramPI = " + GetPI(e));
        }
        public static double GetPI(double e)
        {
            double PI = 1;
            double temp = -1 / 9.0, predTemp;
            int k = 1;
            double l;
            while (true)
            {
                predTemp = Math.Abs(temp);
                PI += temp;
                l = 2 * k + 1;
                temp *= -l / (3 * (l + 2));
                k++;
                if (predTemp - Math.Abs(temp) <= e)
                {
                    PI += temp;
                    break;
                }
            }
            return 2 * Math.Sqrt(3) * PI;
        }
    }
}
