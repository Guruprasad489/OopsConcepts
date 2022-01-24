using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.ClassAndObjects
{
    class Car
    {                                 //Members of class
        public string model;          //Fields
        public string color;
        public int year;
        public int price;
        public void Autopilot()      //Method
        {
            Console.WriteLine("Car has amazing autopilot mode");
        }

        public Car()                //Constructor
        {
            model = "Tata";
            color = "Blue";
            year = 2020;
            price = 1500000;
        }
        public void ElectricVehicle()
        {
            Console.WriteLine("Car runs on electricity");
        }
    }
}
