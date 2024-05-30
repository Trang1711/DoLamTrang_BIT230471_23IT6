using System;

namespace myprogram
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int nInteger = int.Parse(Console.ReadLine());

            double nDouble = (double)nInteger;

            Console.WriteLine("The number you entered is {0} and as a double is {1}.", nInteger, nDouble);
        }
    }
}

