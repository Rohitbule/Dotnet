using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instantiate the derived class
            Dog myDog = new Dog();
            myDog.Name = "Buddy";

            // Call methods from the base class
            myDog.Eat();

            // Call method from the derived class
            myDog.Bark();

            // Wait for user input before closing the console
            Console.ReadLine();
        }
            public class Animal
            {
                    public string Name { get; set; }
                    public void Eat()
                    {
                        Console.WriteLine($"{Name} is eating.");
                    }
            }

                // Derived class
                public class Dog : Animal
                {
                    public void Bark()
                    {
                        Console.WriteLine($"{Name} is barking.");
                    }
                }

        

       

    }
}

