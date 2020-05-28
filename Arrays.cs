using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int [,]b = new int[2,2];
            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = j;
                }
            }


            Console.WriteLine("output1");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("________________________________");


            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }

            Console.WriteLine("output2");
            foreach (int item in a)
            {
                Console.WriteLine(item);
               

            }
            Console.ReadLine();
                
        }
    }
}
