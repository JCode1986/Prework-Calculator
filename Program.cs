using System;

namespace Prework_Calculator
{
    class Program
    {

        public static void UserInput()
        {
            Console.WriteLine("Welcome to a very basic calculator");
            Console.WriteLine("Which operation would you like to do?");
            Console.WriteLine("'a' - add\n's' - subtract\n'm' - multiply\n'd' - divide");
            string operationInput = Console.ReadLine();

            if (operationInput == "a") Console.WriteLine(Add());
            if (operationInput == "s") Console.WriteLine(Subtract());
            if (operationInput == "m") Console.WriteLine(Multiply());
            if (operationInput == "d") Console.WriteLine(Divide());           
        }
        public static string Add()
        {
            Console.WriteLine("Enter first number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            return $"Sum of {numOne} and {numTwo} is {numOne + numTwo}";
        }

        public static string Subtract()
        {
            Console.WriteLine("Enter first number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            return $"Difference of {numOne} and {numTwo} is {numOne - numTwo}";
        }

        public static string Multiply()
        {
            Console.WriteLine("Enter first number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            return $"Product of {numOne} and {numTwo} is {numOne * numTwo}";
        }

        public static string Divide()
        {
            Console.WriteLine("Enter first number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            return $"Quotient of {numOne} and {numTwo} is {numOne / numTwo}";
        }
        static void Main(string[] args)
        {
            UserInput();
        }
    }
}
