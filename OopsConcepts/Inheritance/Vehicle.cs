using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Inheritance
{
    //Base or Parent class
    class Vehicle
    {
        //instance variable
        public string brand = "ADL";  //Vehicle field 

        //instance method
        public void honk()            //Vehicle Method - honk
        {
            Console.WriteLine("Tuut Tuut");  
        }
    }
}
