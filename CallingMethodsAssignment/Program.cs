using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to control the calculation loop
            bool continueCalculation = true;

            // Main calculation loop
            while (continueCalculation)
            {
                // Welcome message
                Console.WriteLine("Hello, Welcome to a simple program that would perform four basic math operations on the numbers you provide !");
                Thread.Sleep(1000); // Pause for 1 second
                Console.WriteLine("We will Add, Substract, Multiply and Divide the numbers!");

                // Get input from the user
                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Display results header
                Console.WriteLine("Here is your answers:");
                Thread.Sleep(500); // Pause for 0.5 seconds

                // Perform calculations and display results
                Console.WriteLine("Addition result : " + MathOpeators.Addition(num1, num2));
                Console.WriteLine("Substraction result : " + MathOpeators.Substraction(num1, num2));
                Console.WriteLine("Multiplication result : " + MathOpeators.Multiplication(num1, num2));

                // Handle division by zero
                if (num2 == 0)
                {
                    Console.WriteLine("Division result : Error: Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine("Division result : " + MathOpeators.Division(num1, num2));
                }

                // Ask if the user wants to continue
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string continueChoice = Console.ReadLine().ToLower();

                // Update the loop control variable based on user input
                if (continueChoice != "y")
                {
                    continueCalculation = false;
                }
            } // End of while loop

            Console.ReadLine(); // Wait for the user to press a key before closing
        }
    }
}
