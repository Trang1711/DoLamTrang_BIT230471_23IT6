using System;
using System.Text;

class Bai2c
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số nguyên n không dấu (1 byte): ");
        byte n = byte.Parse(Console.ReadLine());

        // Tính tổng các số từ 1 đến n
        uint sum = 0;
        for (byte i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
    }
}
