using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;




namespace CallingMethodsAssignment
{
    class MathOpeators
    {
        // Method to add two numbers
        public static double Addition(double num1, double num2)
        {
            return num1 + num2; // Calculates and returns the sum
        }

        // Method to subtract two numbers
        public static double Substraction(double num1, double num2)
        {
            return num1 - num2; // Calculates and returns the difference
        }

        // Method to multiply two numbers
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2; // Calculates and returns the product
        }

        // Method to divide two numbers
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0; // Returns 0 to indicate an error occurred
            }
            else
            {
                return num1 / num2; // Calculates and returns the quotient
            }
        }
    }
}
