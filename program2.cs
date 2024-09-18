using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program2
    {
        public class ClassA
        {
            public string message = "Hello from ClassA in FirstNamespace!";

            public void DisplayMessage()
            {
                Console.WriteLine(message);
            }
        }
    }

    // SecondNamespace
    namespace SecondNames
    {
        // Import FirstNamespace to access ClassA
        using susma.lab2;
        using static susma.lab2.program2;

        class Program
        {
           /* static void Main(string[] args)
            {
                // Create an instance of ClassA from FirstNamespace
                ClassA obj = new ClassA();

                // Access the public field
                Console.WriteLine(obj.message);

                // Access the public method
                obj.DisplayMessage();

                Console.ReadLine();
            }*/
        }
    }
}
