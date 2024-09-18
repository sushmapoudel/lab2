using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program3
    {
        public partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void PrintFullName()
            {
                Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            }
        }

        // Second part of the partial class
        public partial class Person
        {
            public int Age { get; set; }

            public void PrintAge()
            {
                Console.WriteLine("Age: " + Age);
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                Person person = new Person();
                person.FirstName = "susma";
                person.LastName = "poudel";
                person.Age = 21;

                person.PrintFullName();
                person.PrintAge();
                Console.ReadLine();
            }*/
        }
    }
}
