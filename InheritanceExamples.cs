using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{
    class RedmiNote4
    {
       public void Camera()
        {
            Console.WriteLine("hello");
        }

    }

    class RedmiNote5 :RedmiNote4
    {

       public void multiTouch()
        {
            Console.WriteLine("new one");
            Camera();
        }
      
    }



    public class InheritanceExamples
    {
       public static void Main(string[] args)
        {
            RedmiNote5 o = new RedmiNote5();
            o.multiTouch();
            o.Camera();
        }
    }
}
