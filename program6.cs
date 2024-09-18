using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program6
    {
        public class Person
        {
            public string Name;
            public int Age;

            // 1. Default Constructor
            public Person()
            {
                Name = "Unknown";
                Age = 0;
                Console.WriteLine("Default Constructor Called.");
            }

            // 2. Parameterized Constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Parameterized Constructor Called.");
            }

            // 3. Copy Constructor
            public Person(Person person)
            {
                Name = person.Name;
                Age = person.Age;
                Console.WriteLine("Copy Constructor Called.");
            }

            // 4. Static Constructor
            static Person()
            {
                Console.WriteLine("Static Constructor Called.");
            }

            // Method to display the person details
            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + Name + ", Age: " + Age);
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Creating an object using the default constructor
                Person person1 = new Person();
                person1.DisplayInfo();

                Console.WriteLine();

                // Creating an object using the parameterized constructor
                Person person2 = new Person("susma", 20);
                person2.DisplayInfo();

                Console.WriteLine();

                // Creating an object using the copy constructor
                Person person3 = new Person(person2);
                person3.DisplayInfo();

                Console.WriteLine();
                Console.ReadLine();
            }*/
        }
    }
}
