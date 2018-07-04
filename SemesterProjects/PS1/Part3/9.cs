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
            sbyte l, flag = 0;
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (k < 0) l = -1;
            else l = 1;
            for (int i = 1;i < n;i++)
            {
                k = int.Parse(Console.ReadLine());
                if (flag == 0 && k < 0)
                    if (l < 0) flag = 1;
                    else l = -1;
                if (flag == 0 && k > 0)
                    if (l > 0) flag = 1;
                    else l = 1;
            }
            if (flag == 1) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
    }
}
