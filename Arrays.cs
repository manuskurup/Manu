using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{
    class Arrays
    {
        static void Main(string[] args)
        {

            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }

            Console.WriteLine("output");
            foreach (int item in a)
            {
                Console.WriteLine(item);
               

            }
            Console.ReadLine();
                
        }
    }
}
