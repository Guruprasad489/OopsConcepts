using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.MethodOverLoading
{
    class Addition
    {
        public void SumOfTwoVariable(int a, int b) //method parameters
        {
            int sum = a + b;
            Console.WriteLine("Sum is {0}", +sum);
        }
        public void SumOfTwoVariable(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("Sum is {0}", sum);
        }
        public void SumOfTwoVariable(int a, int b, double c)
        {
            double sum = a + b + c;
            Console.WriteLine("Sum is {0}", +sum);
        }
        public void SumOfTwoVariable(int a, double c, int b)
        {
            double sum = a + b +c;
            Console.WriteLine("Sum is {0}", +sum);
        }
    }
}
