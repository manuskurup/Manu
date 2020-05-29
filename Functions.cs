using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{

    class A
    {
       
    }
    public class Emp1
    {
      public  void SameName()
        {
            Console.WriteLine("Same Name");
        }
        public void SameName(string pram1)
        {
            Console.WriteLine(pram1);
        }

    }

    class Functions
    {
        static void Main(string[] args)
        {
            Emp1 o = new Emp1();
            o.SameName();
            o.SameName("Manu");
            Console.ReadKey();

        }
    }
}
