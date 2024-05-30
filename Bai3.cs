using System;

namespace CharToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a character
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadLine()[0];

            // Convert the character to its ASCII code (int)
            int asciiCode = (int)inputChar;

            // Display the results
            Console.WriteLine($"The character you entered is '{inputChar}', its ASCII code is {asciiCode}");
        }
    }
}

