using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.MethodOverWriting
{
    class PartTimeEmployee : Employee
    {
        public void EmpDetails()
        {
            Console.WriteLine("Part Time Emp Name xyz");
        }
        public void GetSalary()
        {
            Console.WriteLine("PartTimeEmployee Salary: {0}", salary);
        }
    }
}
