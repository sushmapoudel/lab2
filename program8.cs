using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program8
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

            // Overloading the binary 
            public static Point operator +(Point p1, Point p2)
            {
                
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
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
                // Creating two Point objects
                Point p1 = new Point(10, 20);
                Point p2 = new Point(30, 40);

                Console.WriteLine("Point 1:");
                p1.Display();

                Console.WriteLine("Point 2:");
                p2.Display();

                // Using the overloaded + operator to add two points
                Point p3 = p1 + p2;

                Console.WriteLine("\nPoint after adding Point 1 and Point 2:");
                p3.Display();
                Console.ReadLine();
            }*/
        }
    }
}

