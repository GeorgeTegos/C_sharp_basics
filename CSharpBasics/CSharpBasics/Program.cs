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
            Console.Write("What's your name?\n");

            // Safe input into Variable
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            // Variables
            bool canIVote = true;
            string nickname = "gtultimate";
            int age = 30;
            int biggestInt = int.MaxValue;
            int smallestInt = int.MinValue;
            long biggestLong = long.MaxValue;
            long smallestLong = long.MinValue;

            Console.WriteLine($"Hello {name} '{nickname}', your age {age}.");
            Console.WriteLine("Biggest Int : {0} , Smallest Int : {1}",biggestInt,smallestInt);
            Console.WriteLine("Biggest Long : {0} , Smallest Long : {1}", biggestLong, smallestLong);

            // Decimals, Add M at the end

            decimal firstDecimal = 2.3123422123M;
            decimal secondDecimal = 3.2123455234m;

            Console.WriteLine("The sum of {0} and {1} = {2}",firstDecimal,secondDecimal,firstDecimal + secondDecimal);
        }
    }
}