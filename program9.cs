using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program9
    {
        public class Person
        {
            // Private fields
            private string name;
            private int age;
            private double salary;

            // 1. Read-Write Property (Allows both getting and setting)
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // 2. Read-Only Property (Only allows getting)
            public int Age
            {
                get { return age; }
            }

            // 3. Write-Only Property (Only allows setting)
            public double Salary
            {
                set { salary = value; }
            }

            // 4. Auto-Implemented Property (No explicit backing field required)
            public string Address { get; set; }

            // Constructor to initialize age (since it's read-only)
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Method to display details
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Address: {Address}");
            }

            // Method to display salary (since it's write-only)
            public void DisplaySalary()
            {
                Console.WriteLine($"Salary: {salary}");
            }
        }

        class Program
        {
          /*  static void Main(string[] args)
            {
                // Creating a Person object
                Person person = new Person("John", 30);

                // Accessing Read-Write property
                person.Name = "Jane"; // Setting the name
                Console.WriteLine("Updated Name: " + person.Name); // Getting the name

                // Accessing Read-Only property (cannot set)
                Console.WriteLine("Age: " + person.Age); // Getting the age

                // Accessing Write-Only property (cannot get)
                person.Salary = 50000; // Setting the salary (no way to get it directly)

                // Accessing Auto-Implemented Property
                person.Address = "123 Main St"; // Setting the address
                Console.WriteLine("Address: " + person.Address); // Getting the address

                // Display all information
                Console.WriteLine("\nPerson Details:");
                person.DisplayInfo();

                // Display salary (since it's write-only, it needs to be printed in a method)
                Console.WriteLine("\nSalary Info:");
                person.DisplaySalary();
                Console.ReadLine();
            }*/
        }
    }
}
