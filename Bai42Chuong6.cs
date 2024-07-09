using System;
using System.Collections.Generic;

class Bai42Chuong6
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 3, 9, 1 };

        numbers.Sort();
        numbers.Reverse();
        numbers.Insert(2, 7);
        numbers.Remove(3);
        numbers.RemoveAt(0);

        bool containsNine = numbers.Contains(9);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Contains 9: " + containsNine);
    }
}
