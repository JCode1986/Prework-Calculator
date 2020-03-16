using System;

namespace Prework_Calculator
{
    class Program
    {
        public static void StartApp()
        {
            Console.WriteLine("Welcome to a very basic calculator");
            Console.WriteLine("Which operation would you like to do?");
            Console.Write(UserInput());
        }
        public static string UserInput()
        {
            Console.WriteLine("'a' - add\n's' - subtract\n'm' - multiply\n'd' - divide");
            string operationInput = Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            

            if(operationInput == "a") Console.WriteLine(Add(numOne, numTwo));
            if(operationInput == "s") Console.WriteLine(Subtract(numOne, numTwo));
            if(operationInput == "m") Console.WriteLine(Multiply(numOne, numTwo));
            if(operationInput == "d") Console.WriteLine(Divide(numOne, numTwo)); 
            Continue(); 
            return null;       
        }

        public static string Continue()
        {
            Console.WriteLine("would you like to do another operation?: (y/n) ");
            string response = Console.ReadLine();
            return response == "y" ? UserInput() : End();
        }

        public static string End()
        {
            return "Thank you for using the basic calculator";
        }

        public static string Add(int numOne, int numTwo)
        {
            return $"Sum of {numOne} and {numTwo} is {numOne + numTwo}";
        }

        public static string Subtract(int numOne, int numTwo)
        {
            return $"Difference of {numOne} and {numTwo} is {numOne - numTwo}";
        }

        public static string Multiply(int numOne, int numTwo)
        {
            return $"Product of {numOne} and {numTwo} is {numOne * numTwo}";
        }

        public static string Divide(int numOne, int numTwo)
        {
            return numTwo != 0 ? $"Quotient of {numOne} and {numTwo} is {numOne / numTwo}" : "Enter a non-zero divisor";
        }
        static void Main(string[] args)
        {
            StartApp();
        }
    }
}
