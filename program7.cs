using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program7
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            // Constructor to initialize the point
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Overloading the unary operator
            public static Point operator -(Point p)
            {
                // Negating both X and Y coordinates
                return new Point(-p.X, -p.Y);
            }

            // Display the coordinates
            public void Display()
            {
                Console.WriteLine($"Point Coordinates: ({X}, {Y})");
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Creating a Point object
                Point p1 = new Point(10, 20);
                Console.WriteLine("Original Point:");
                p1.Display();

                // Using the overloaded unary minus operator
                Point p2 = -p1;

                Console.WriteLine("\nPoint after applying unary minus operator:");
                p2.Display();
                Console.ReadLine();
            }*/
        }
    }
}
