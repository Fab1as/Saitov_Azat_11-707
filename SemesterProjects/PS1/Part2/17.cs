using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        public static long ConverFrom16To10(string number16)
        {
            const string dictionary = "0123456789ABCDEF";
            long number10 = 0, exp = 1;
            for (int i = number16.Length - 1; i >= 0; i--)
            {
                number10 += dictionary.IndexOf(number16[i]) * exp;
                exp *= 16;
            }
            return number10;
        }

        public static string ConverFrom10ToAny(long number10, sbyte k)
        {
            string numberK ="";
            string numerable;
            while (number10 > 0)
            {
                numerable = Convert.ToString(number10 % k);
                numberK = numberK.Insert(0 , numerable);
                number10 /= k;
            }
            return numberK;
        }

        static void Main(string[] args)
        {
            string strNumber = Console.ReadLine();
            sbyte k = sbyte.Parse(Console.ReadLine());
            if (k == 16) Console.WriteLine(strNumber);
            else if (k == 10)
            {
                long number10 = ConverFrom16To10(strNumber);
                Console.WriteLine(number10);
            }
            else
            {
                long number10 = ConverFrom16To10(strNumber);
                Console.WriteLine(ConverFrom10ToAny(number10, k));
            }
        }
    }
}