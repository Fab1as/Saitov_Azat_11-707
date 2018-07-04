using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            int steps;
            Console.WriteLine("Cosinus = {0:0.0000}", Math.Cos(x));
            Console.WriteLine("Cos = {0:0.0000}", GetCos(x, e, out steps));
            Console.WriteLine("Steps = " + steps);
        }

        public static double GetCos(double x, double e, out int k)
        {
            double temp = 1;
            double cos = 0;
            k = 1;
            while (Math.Abs(temp) > e)
            {
                cos += temp;
                temp *= -x * x / ((2 * k - 1) * (2 * k));
                k++;
            }
            return cos;
        }
    }
}
