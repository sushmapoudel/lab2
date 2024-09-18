using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program4
    {
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        // Single Inheritance: Dog inherits from Animal
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

        // Multilevel Inheritance: Puppy inherits from Dog, which inherits from Animal
        public class Puppy : Dog
        {
            public void Play()
            {
                Console.WriteLine("Puppy is playing.");
            }
        }

        // Hierarchical Inheritance: Cat also inherits from Animal
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("Cat is meowing.");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Demonstrating Single Inheritance
                Dog dog = new Dog();
                dog.Eat();    // Inherited from Animal
                dog.Bark();   // Dog's own method

                Console.WriteLine();

                // Demonstrating Multilevel Inheritance
                Puppy puppy = new Puppy();
                puppy.Eat();    // Inherited from Animal
                puppy.Bark();   // Inherited from Dog
                puppy.Play();   // Puppy's own method

                Console.WriteLine();

                // Demonstrating Hierarchical Inheritance
                Cat cat = new Cat();
                cat.Eat();    // Inherited from Animal
                cat.Meow();   // Cat's own method
                Console.ReadLine();
            }*/
        }
    }
}
