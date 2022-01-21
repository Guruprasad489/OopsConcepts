using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Interface
{
    class Pigs : Ianimal, Itiger
    {
        public void AnimalSound()
        {
            Console.WriteLine("Pig interface method");
        }

        public void Details()
        {
            Console.WriteLine("Tiger interface method");
        }

        public void Sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}
