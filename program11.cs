using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susma.lab2
{
    internal class program11
    {
        public class GenericClass<T>
        {
            private T _value;

            // Constructor to initialize the generic value
            public GenericClass(T value)
            {
                _value = value;
            }

            // Method to get the value
            public T GetValue()
            {
                return _value;
            }

            // Method to display the value
            public void DisplayValue()
            {
                Console.WriteLine("Value: " + _value);
            }

            // Generic method inside a generic class
            public void DisplayTwoValues<U>(T firstValue, U secondValue)
            {
                Console.WriteLine("First Value: " + firstValue);
                Console.WriteLine("Second Value: " + secondValue);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Using GenericClass with int type
                GenericClass<int> intObj = new GenericClass<int>(42);
                intObj.DisplayValue();  // Output: 42

                // Using GenericClass with string type
                GenericClass<string> stringObj = new GenericClass<string>("Hello, Generics!");
                stringObj.DisplayValue();  

                // Calling the generic method with two different types
                intObj.DisplayTwoValues<int>(100, 200);   
                stringObj.DisplayTwoValues<string>("First", "Second");  
                Console.ReadLine();
            }
        }
    }
}
