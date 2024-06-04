using System;
using System.Text;

class Bai4a
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số nguyên không dấu 8 byte: ");
        ulong num = ulong.Parse(Console.ReadLine());

        // Kiểm tra số Palindrome
        ulong originalNum = num;
        ulong reversedNum = 0;
        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        if (originalNum == reversedNum)
        {
            Console.WriteLine($"{originalNum} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{originalNum} không phải là số Palindrome.");
        }
    }
}