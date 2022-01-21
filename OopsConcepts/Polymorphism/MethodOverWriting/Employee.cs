using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.MethodOverWriting
{
    class Employee
    {
        public double salary;
        public void EmpDetails()
        {
            Console.WriteLine("Emp Name abc");
        }
        public void GetSalary()
        {
            Console.WriteLine("Employee Salary: {0}", salary);
        }

    }
}
