using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    class Hero : Bike
    {
        public override void BikePrice()
        {
            Console.WriteLine("Bike has reasonable price");
        }
    }
}
