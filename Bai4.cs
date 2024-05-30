using System;

namespace FindMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the size of the array
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Create an array to store the integers
            int[] numbers = new int[size];

            // Prompt the user to enter the array elements
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the maximum value in the array
            int maxValue = numbers[0];
            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }

            // Display the maximum value
            Console.WriteLine($"The maximum value in the array is: {maxValue}");
        }
    }
}


