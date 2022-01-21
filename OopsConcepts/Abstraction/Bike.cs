using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    abstract class Bike
    {
        public int model;
        public abstract void BikePrice();
        public static void BikeWeight()
        {
            Console.WriteLine("Bike is heavy");
        }
    }
    
}
