using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program1
    {
      

class Employee
    {
        // Fields for Employee
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

       
        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            // Create Employee object
            Employee emp = new Employee("susma poudel", "susma@.com", 50000);

            // Display Employee details
            emp.DisplayEmployeeDetails();

            Console.ReadLine(); 
        }*/
    }
}
}
