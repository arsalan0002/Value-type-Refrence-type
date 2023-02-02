using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALUE_TYPE_REFERENCE_TYPE
{

// STRUCT VALUE TYPE....
    
    struct Employee
    {
        public int Salary;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;
            Console.WriteLine(e.Age); // 23


            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e.Age); //25
            Console.WriteLine(e1.Age); //23
            Console.WriteLine(e2.Age); //23
            Console.ReadLine();

        }
    }

//------------------------------------------------------------------------------------------------------------
// CLASS REFRENCE TYPE...........

    // class Employee
    // {
    //     public int Salary;
    //     public int Age;
    // }

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
            // Employee e = new Employee();
            // e.Salary = 5000;
            // e.Age = 23;
            // Console.WriteLine(e.Age); // 23


            // Employee e1 = e;
            // Employee e2 = e;

            // e.Age = 25;
            // Console.WriteLine(e.Age); //25
            // Console.WriteLine(e1.Age); //25
            // Console.WriteLine(e2.Age); //25
            // Console.ReadLine();

    //     }
    // }
}
