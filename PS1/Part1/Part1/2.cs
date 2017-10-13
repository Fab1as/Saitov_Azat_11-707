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
            string s = Console.ReadLine();
            string v = Console.ReadLine();
            if (s[0] == v[0]) //Проверяется первая буква изначальной координаты и введённой, поскольку пешка ходит лишь вверх
            {
                if (s[1] == '2' && v[1] == '4') Console.WriteLine("YES"); //Если пешка ещё ни разу не делала ход, то она может переместиться сразу на две единицы
                else if (v[1] - s[1] == 1) Console.WriteLine("YES");
                     else Console.WriteLine("NO");
            }
            else Console.WriteLine("NO");
        }
    }
}
