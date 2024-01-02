using System;
using System.Text.RegularExpressions;



namespace CSharpBasics
{
    public class Program
    {
        // Basic code to run Main
        static void Main(string[] args)
        {
            // Write in console and edit console background & text color
            Console.WriteLine("--------------Console output/input-----------------------------------");

            Console.BackgroundColor = ConsoleColor.Black; // Default Black
            Console.ForegroundColor = ConsoleColor.White; // Default White
            Console.Clear();
            Console.WriteLine("This is a console Text test");


            // Get user input from console
            Console.Write("What's your name?\n");

            // Safe input into Variable
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("------------------------------------------------------");

            // Variables
            Console.WriteLine("---------------Different Variables-------------------------------");

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

            double biggestDouble = Double.MaxValue;
            double smallestDouble = Double.MinValue;

            Console.WriteLine("Biggest Int : {0} , Smallest Int : {1}", biggestDouble, smallestDouble);


            // Decimals, Add M at the end
            decimal firstDecimal = 2.3123422123M;
            decimal secondDecimal = 3.2123455234m;

            Console.WriteLine("The sum of {0} and {1} = {2}",firstDecimal,secondDecimal,firstDecimal + secondDecimal);
            Console.WriteLine("------------------------------------------------------");


            //Casting 
            Console.WriteLine("-----------------Casting-------------------------------");

            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("12345");
            double doubleFromString = double.Parse("1.2345");
            string stringFroMDouble = doubleFromString.ToString();

            Console.WriteLine($"Data Type: {stringFroMDouble.GetType()}");
            double dblNum = 12.345;

            //Explisit Conversion
            Console.WriteLine($"Int: {(int)dblNum}");

            //Implisit Conversion
            int intNUm = 10;
            long longNum = intNUm;

            Console.WriteLine("------------------------------------------------------");

            // output formating examples
            Console.WriteLine("-------------------Currency/Numbers Formating-------------------");


            // X:c will format this value as $ currency
            Console.WriteLine("Currency :{0:c}", 23.456);
            // Put 0 infront , padding x amount ,  dx
            Console.WriteLine("Pad with 0:{0:d4}", 23);
            // put max X number of decimals  fx
            Console.WriteLine("3 Decimals Max: {0:f3}", 23.423256);
            // add commas and X amound of decimals.  nx
            Console.WriteLine("Automatic Comas:{0:n2}", 12345);


            // String Function
            Console.WriteLine("-------------------String Functions/Methods--------------------");

            string randomString = "This is just a string";
            Console.WriteLine("String lenght :{0}", randomString.Length);
            Console.WriteLine("String contains is :{0}",randomString.Contains("is"));
            Console.WriteLine("String index of is :{0}", randomString.IndexOf("is"));
            Console.WriteLine("String remove :{0}", randomString.Remove(10,6));
            Console.WriteLine("String add :{0}", randomString.Insert(13, "short "));
            Console.WriteLine("String replace :{0}", randomString.Replace("string","sentence"));


            // Replace with Regex, creater patter and give flag options
            string pattern = "iS";
            string regexStringChanged = Regex.Replace(randomString,pattern , "IS", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Console.WriteLine("Regex replace : {0}", regexStringChanged);

            // Compare Strings ignoring case
            // Not returning 0 means they are not equal
            Console.WriteLine("String compare A to B :{0}", String.Compare("A","B",StringComparison.OrdinalIgnoreCase));
            // Returning 0 means they are equal
            Console.WriteLine("String compare Aa to aa :{0}", String.Compare("Aa", "aa", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("A = a :{0}",String.Equals("A","a",StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Pad left: {0}",
                randomString.PadLeft(20,'.'));
            Console.WriteLine("Pad right: {0}",
                randomString.PadRight(20, '.'));

            Console.WriteLine("Pad left: {0}",
                randomString.Trim());
            Console.WriteLine("Uppercase :{0}", randomString.ToUpper());
            Console.WriteLine("Lowercase : {0}",randomString.ToLower());

            string newString = String.Format("{0} saw {1} {2} in the {3}",
                "Paul".ToUpper(), "raBBit".ToLower(), "eatting", "field");
            Console.Write(newString+ "\n");


            Console.WriteLine("------------------------------------------------------");


        }
    }
}


