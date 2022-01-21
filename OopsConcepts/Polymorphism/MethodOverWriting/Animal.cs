using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.MethodOverWriting
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
       public override void animalSound()
       {
           Console.WriteLine("The dog says: bow wow");
       }
    }
}
