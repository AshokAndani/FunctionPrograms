﻿namespace FunctionPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factorial:");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Write("Enter the input for factorial: ");
                    int inp = int.Parse(Console.ReadLine());
                    Factorial factorial = new Factorial();
                    int result = factorial.Fact(inp);
                    Console.WriteLine($"factorial of {inp} is : {result}");
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}