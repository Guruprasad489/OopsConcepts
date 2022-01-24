using OopsConcepts.Abstraction;
using OopsConcepts.ClassAndObjects;
using OopsConcepts.Encapsulation;
using OopsConcepts.Inheritance;
using OopsConcepts.Interface;
using OopsConcepts.PassByValueAndRefernece;
using OopsConcepts.Polymorphism.MethodOverLoading;
using OopsConcepts.Polymorphism.MethodOverWriting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("class and object concept....");
            Car Tesla = new Car();
            Tesla.model = "Roadster";
            Tesla.color = "Red";
            Tesla.year = 2020;
            Tesla.price = 5000000;
            Tesla.Autopilot();
            Console.WriteLine("{0} {1} {2} {3}", Tesla.model, Tesla.color, Tesla.year, Tesla.price);

            Console.WriteLine("\n Constructor concept....");
            Car Tata = new Car();
            Tata.ElectricVehicle();
            Console.WriteLine(Tata.model+" "+Tata.color+" "+Tata.year+" "+Tata.price); 

            Console.WriteLine("\n Inheritance....");
            Bus bus = new Bus();
            bus.brand = "Tata";
            bus.honk();
            bus.Electric();

            //int x= 10, y = 20;              //method arguments
            Console.WriteLine("\n ethod overloading....");
            Addition addition = new Addition();
            addition.SumOfTwoVariable(10, 20, 20);

            Console.WriteLine("\n Method overriding....");
            Employee employee = new Employee();
            employee.salary = 500;
            employee.EmpDetails();
            employee.GetSalary();
            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.salary = 250;
            partTime.EmpDetails();
            partTime.GetSalary();

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Console.WriteLine("\n Encapsulation....");
            Account account = new Account();
            account.SetbBalance(1000);
            account.GetBalance();

            Console.WriteLine("\n Abstraction....");
            Hero hero = new Hero();
            hero.BikePrice();
            hero.model = 3;

            Console.WriteLine("\n Interface....");
            Pigs pigs = new Pigs();
            pigs.AnimalSound();
            pigs.Details();

            Console.WriteLine("\n Pass By Value....");
            int i = 100;
            Console.WriteLine(i);
            PassByValue.ChangeValue(i);
            Console.WriteLine(i);

            Console.WriteLine("\n Pass By Reference....");
            PassByReference.TestRef();
        }
    }
}
