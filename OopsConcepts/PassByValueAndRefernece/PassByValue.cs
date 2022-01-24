using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.PassByValueAndRefernece
{
    internal class PassByValue
    {
        public static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
    }
}
