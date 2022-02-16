using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, result;

            Console.WriteLine("Temperature Calculator");

            Console.WriteLine("Please enter a Temperature in Celsius:");
            input = Convert.ToSingle(Console.ReadLine());

            result = (input * 1.8) + 32;

            Console.WriteLine("\nBlake Hadaway - Assignment 1 Part 2\n");
            Console.WriteLine("Name: Blake Hadaway");
            Console.WriteLine("Email: Blake.j.hadaway@gmail.com");
            Console.WriteLine("The Celsius temperature of " + input + " degrees converts to " + result + " in fahrenheit");
            Console.WriteLine("Experience: Moderate");
            Console.WriteLine("Country: Canada");

        }
    }
}
