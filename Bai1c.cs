using System;
using System.Text;

namespace ReverseNumber
{
    class Bai1c
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            uint number;

            // Nhập số nguyên không dấu
            Console.Write("Nhập số nguyên không dấu (4 byte): ");
            while (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại.");
            }

            // Đảo ngược số
            uint reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + (number % 10);
                number /= 10;
            }

            Console.WriteLine("Số đảo ngược: {0}", reversedNumber);
        }
    }
}