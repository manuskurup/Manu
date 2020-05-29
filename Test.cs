using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{
    class Sample
    {
       public  Sample()//Default
        {
            Console.WriteLine("Good morning");
        }
        public Sample(int x)
        {
            Console.WriteLine(x);
        }

       public void hello()
        {
            Console.WriteLine("Hello");
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample(2);
            Sample obj2 = new Sample();
            obj.hello();
            Console.ReadKey();
        }

    }
}
