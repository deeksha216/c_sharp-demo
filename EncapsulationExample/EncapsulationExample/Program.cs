using System;

namespace EncapsulationExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            EncapsulationExample person = new EncapsulationExample();

            
            person.Name = "Alice";
            person.age = 25;

           
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.age);

           
            person.Name = "";     
            person.age = -1;      
        }
    }
}
