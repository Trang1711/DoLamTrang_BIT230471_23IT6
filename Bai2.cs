using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a real number: ");
        string userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput))
        {
            double userNumber = double.Parse(userInput);

            int intNumber = (int)Math.Round(userNumber);
            long longNumber = (long)Math.Round(userNumber);

            Console.WriteLine($"The number you entered is {userNumber}, as an int is {intNumber} and as a long is {longNumber}.");
        }
        else
        {
            Console.WriteLine("You did not enter a valid number.");
            Console.ReadKey();
        }
    }
}

