using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.PassByValueAndRefernece
{
    public class Planet
    {
        public string Name;
    }
    internal class PassByReference
    {
        public static void ChangeReference(string lang2, Planet planet2)
        {
            lang2 = "java";
            planet2.Name = "Mars";
            
        }
        public static void TestRef()
        {
            Planet planet1 = new Planet();
            planet1.Name = "Earth";
            string lang1 = "C#";
            Console.WriteLine("Before passing ref: " +planet1.Name + " " + lang1);
            ChangeReference(lang1, planet1);
            Console.WriteLine("After passing ref:" +planet1.Name + " " + lang1);    
            
            //lang1 will not chnage java because string is a immutable 
        }
    }
}
