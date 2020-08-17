using System;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Converter
    {
        public static int StrToInt(string inpStr)
        {
            int response = 0;
            // loop through string, multiply response int by 10, add char - '0' to response to convert
            foreach (char c in inpStr)
            {
                response *= 10;
                response += c - '0';
            }


            return response;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string strToConv = Console.ReadLine();
            if (Regex.IsMatch(strToConv, @"^\d+$")) // Regex searches for any decimal digit
            {
                Console.WriteLine($"{strToConv} is a string = {strToConv is string}");
                int result = Converter.StrToInt(strToConv);
                Console.WriteLine($"{result} has been converted to an integer = {result is int}");

            }
            else
            {
                Console.WriteLine("Input must be a number");
            }
        }
    }
}
