using System;

namespace Semestrovochka
{
    class Program
    {
        static void Main()
        {

            var array1 = new int[10][]
            {
                new int[]{1,1,1-3,1,1,1,1,1,1,1},
                new int[]{0,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1-1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,-2,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1},
                new int[]{1,1,1,1,1,1,1,1,1,1}
            };

            //var array0 = new int[10][]
            //{
            //    new int[]{0,0,0,0,0,0,0,0,0,3},
            //    new int[]{0,0,0,0,0,0,0,0,0,2},
            //    new int[]{0,0,0,0,0,0,0,0,0,3},
            //    new int[]{0,0,0,0,0,0,0,0,0,4},
            //    new int[]{0,0,0,0,0,0,0,0,0,5},
            //    new int[]{0,0,0,0,0,0,0,0,0,1},
            //    new int[]{0,0,0,0,0,0,0,0,0,7},
            //    new int[]{0,0,0,0,0,0,0,0,0,8},
            //    new int[]{0,0,0,0,0,0,0,0,0,9},
            //    new int[]{0,0,0,0,0,0,0,0,0,11}
            //};

            var matrix = new MatrixCode(array1);
            var aList = matrix.MinList();
            foreach (var i in aList)
            {
                Console.Write(i + " ");
            }
            array1 = matrix.Decode();


            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    Console.Write("{0,6}  ", array1[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }  
}