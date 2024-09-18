using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program5
    {
        public class Animal
        {
            // Virtual method in the base class
            public virtual void Speak()
            {
                Console.WriteLine("Animal is making a sound.");
            }
        }

       
        public class Dog : Animal
        {
            // Override the virtual method
            public override void Speak()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

       
        public class Cat : Animal
        {
            // Override the virtual method
            public override void Speak()
            {
                Console.WriteLine("Cat is meowing.");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
               
                Animal animal = new Animal();
                animal.Speak();  // Calls the base class method

               
                Animal dog = new Dog();
                dog.Speak();  // Calls the overridden method in Dog class

             
                Animal cat = new Cat();
                cat.Speak();  // Calls the overridden method in Cat class
                Console.ReadLine();
            }*/
        }
    }
}

