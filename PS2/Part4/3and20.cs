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
            Console.WriteLine("Введите номер функции:");
            byte functionNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите левую границу:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите правую границу:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("LeftRectangleIntegral = " + GetLeftRectangleIntegral(a, b, n, functionNumber));
            Console.WriteLine("RigthRectangleIntegral = " + GetRightRectangleIntegral(a, b, n, functionNumber));
            Console.WriteLine("TrapezeIntegral = " + GetTrapezeIntegral(a, b, n, functionNumber));
            Console.WriteLine("SimpsonsIntegral = " + GetSimpsonsIntegral(a, b, n, functionNumber));
            Console.WriteLine("MonteCarlointegral = " + GetMonteCarloIntegral(a, b, n, functionNumber));
        }

        public static double GetLeftRectangleIntegral(double a, double b , int n,byte functionNumber)
        {
            double sum = 0;
            double delta = (b - a) / n;
            if (functionNumber == 1)
                for (int i = 0; i < n; i++)
                    sum += Function1(a + i * delta) * delta;
            else
                for (int i = 0; i < n; i++)
                    sum += Function2(a + i * delta) * delta;
            return sum;
        }

        public static double GetRightRectangleIntegral(double a, double b, int n, byte functionNumber)
        {
            double sum = 0;
            double delta = (b - a) / n;
            if (functionNumber == 1)
                for (int i = 0; i < n; i++)
                    sum += Function1(b - i * delta) * delta;
            else
                for (int i = 0; i < n; i++)
                    sum += Function2(b - i * delta) * delta;
            return sum;
        }

        public static double GetTrapezeIntegral(double a, double b, int n, byte functionNumber)
        {
            double sum = 0;
            double delta = (b - a) / n;
            double rightBase;
            if (functionNumber == 1)
            {
                double leftBase = Function1(a);
                for (int i = 1; i <= n; i++)
                {
                    rightBase = Function1(a + i * delta);
                    sum += leftBase + rightBase;
                    leftBase = rightBase;
                }
            }
            else
            {
                double leftBase = Function2(a);
                for (int i = 1; i <= n; i++)
                {
                    rightBase = Function2(a + i * delta);
                    sum += leftBase + rightBase;
                    leftBase = rightBase;
                }
            }
            return sum * delta / 2;
        }

        public static double GetSimpsonsIntegral(double a, double b, int n, byte functionNumber)
        {
            double delta = (b - a) / n;
            n /= 2;
            double sum1 = 0, sum2 = 0;
            if (functionNumber == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i != n) sum1 += Function1(a + 2 * i * delta); // Я бы мог запустить два цикла для рассчёта двух сумм
                                                                      // В моём случае цикл один, но каждый цикл проверяется условие
                    sum2 += Function1(a + 2 * (i - 1) * delta);
                }
                a = Function1(a);
                b = Function1(b);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i != n) sum1 += Function2(a + 2 * i * delta);
                    sum2 += Function2(a + 2 * (i - 1) * delta);
                }
                a = Function2(a);
                b = Function2(b);
            }
            return delta / 3 * ((a + b + 2 * sum1 + 4 * sum2));
        }

        public static double GetMonteCarloIntegral(double a, double b, int n, byte functionNumber)
        {
            double sum = 0;
            double delta = (b - a) / n;
            Random rnd = new Random();
            double i;
            if (functionNumber == 1)
            for (int j = 0; j < n; j++)
            {
                i = rnd.Next(0, n);
                sum += Function1(a + i * delta);
            }
            else
            for (int j = 0;j < n;j++)
            {
                i = rnd.Next(0, n);
                sum += Function2(a + i * delta);
            }
            return delta * sum;
        }

        public static double Function1(double x)
        {
            return -Math.Tan(1 / x + x);
        }

        public static double Function2(double x)
        {

            return Math.Cos(Math.Sin(10 * x))* Math.Cos(Math.Sin(10 * x));
        }
    }
}
