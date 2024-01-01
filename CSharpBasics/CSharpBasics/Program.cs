using System;

namespace CSharpBasics
{
    public class Program
    {
        // Basic code to run Main
        static void Main(string[] args)
        {
            // Write in console and edit console background & text color
            Console.BackgroundColor = ConsoleColor.Black; // Default Black
            Console.ForegroundColor = ConsoleColor.White; // Default White
            Console.Clear();
            Console.WriteLine("This is a console Text test");


            // Get user input from console
            Console.Write("What's your name?");

            // Create Variable
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}