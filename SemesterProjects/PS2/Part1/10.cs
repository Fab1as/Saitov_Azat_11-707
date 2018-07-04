using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            int steps;
            Console.WriteLine("CompRoot = " + Math.Sqrt(1+x));
            Console.WriteLine("√(1+x) = " + GetQuadraticRoot(x, e, out steps));
            Console.WriteLine("Steps = " + steps);
        }

        public static double GetQuadraticRoot(double x, double e, out int k)
        {
            // на ULearn говорилось, что лучше выполнять циклы подобного рода с while(true) и break внутри цикла
            // если нужно, могу отправить цикл с while(predTemp - Math.Abs(temp) > e)
            double quadRoot = 1; // равен единице, потому что первый член суммы равен единице, и считать его нет смысла
            double temp = 0.5 * x; // следующее слагаемое, при k = 1
            double predTemp;
            k = 1;
            while (true)
            {
                quadRoot += temp;
                predTemp = Math.Abs(temp);
                k++;
                temp *= x * (3 - 2 * k) / (2 * k);
                if (predTemp - Math.Abs(temp) <= e)
                {
                    quadRoot += temp;
                    k++; //увеличиваю на 1, чтобы не вводить новую переменную, считающую количество шагов
                         //k отличается от количество шагов на -1
                    break;
                }
            }
            return quadRoot;
        }
    }
}
