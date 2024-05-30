using System;
using System.Linq;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            // Call the ReverseString method and print the reversed string
            string reversedString = ReverseString(userInput);
            Console.WriteLine("Reversed string: " + reversedString);

            // Prompt the user to enter a search string
            Console.WriteLine("Enter a search string:");
            string searchString = Console.ReadLine();

            // Call the CountOccurrences method and print the number of occurrences
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine("Number of occurrences: " + occurrences);

            // Prompt the user to enter an old substring and a new substring
            Console.WriteLine("Enter an old substring:");
            string oldSubstring = Console.ReadLine();
            Console.WriteLine("Enter a new substring:");
            string newSubstring = Console.ReadLine();

            // Call the ReplaceSubstring method and print the modified string
            string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine("Modified string: " + modifiedString);

            // Call the RemoveWhitespace method and print the string without whitespace
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine("String without whitespace: " + stringWithoutWhitespace);
        }

        static string ReverseString(string inputString)
        {
            return string.Concat(inputString.Reverse());
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            return inputString.Split(new[] { searchString }, StringSplitOptions.None).Length - 1;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return inputString.Replace(" ", "");
        }
    }
}