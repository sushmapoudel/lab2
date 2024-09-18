using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program10
    {
        public class Shape
        {
            // Properties for Length and Breadth
            public double Length { get; set; }
            public double Breadth { get; set; }

            // Default constructor
            public Shape()
            {
                Length = 0;
                Breadth = 0;
            }

            // Parameterized constructor 
            public Shape(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }
        }

      
        public class Rectangle : Shape
        {
           
            public Rectangle(double length, double breadth) : base(length, breadth)
            {
            }

            // Method to calculate area of the rectangle
            public double CalculateArea()
            {
                return Length * Breadth;
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Creating an object of Rectangle with specific Length and Breadth
                Rectangle rectangle = new Rectangle(10.5, 5.5);

                // Displaying the Length and Breadth
                Console.WriteLine("Length: " + rectangle.Length);
                Console.WriteLine("Breadth: " + rectangle.Breadth);

                // Calculating and displaying the area of the rectangle
                double area = rectangle.CalculateArea();
                Console.WriteLine("Area of Rectangle: " + area);
                Console.ReadLine();
            }*/
        }
    }
}
