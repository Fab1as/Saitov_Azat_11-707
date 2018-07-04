using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine($"CubicRoot({x}) = " + Math.Pow(x, 1 / 3.0));
            Console.WriteLine($"Program Output = " + GetTernaryRoot(x, e));
        }
        public static double GetTernaryRoot(double x, double e)
        {
            double y, yPrev;
            if (x >= 1) y = x / 3;
            else y = x;
            while (true)
            {
                yPrev = y;
                y = 1/3.0 * (2 * yPrev + x / (yPrev * yPrev));            //преобразованный вид
                //y = yPrev - (1 / 3.0) * (yPrev - x / (yPrev * yPrev));  //основной(как в условиях задачи)
                if (Math.Abs(yPrev - y) <= e) break;
            }
            return y;
        }
    }
}
