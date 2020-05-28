using System;
using System.Collections.Generic;
using System.Text;

namespace Manu
{


    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
    public class Student
    {
      
       public  string Name;
        int M1, M2;
        
        public int Age { get; set; }

        private int RollNo;
        public void SetRollNo(int RollNo)
        {
            this.RollNo = RollNo;

        }
        public int GetRollNo()
        {
            return this.RollNo;
        }





        void Total()//function
        {

        }
    }

    class OOPS
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "vishnu";
            s1.Age = 12;
            Console.WriteLine(s1.Age);

            s1.SetRollNo(2);
            Console.WriteLine(s1.GetRollNo());
        }

    }
}
