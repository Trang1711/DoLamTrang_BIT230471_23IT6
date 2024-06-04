using System;
using System.Text;

class Bai2d
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số nguyên không dấu (1 byte): ");
        byte n = byte.Parse(Console.ReadLine());

        // Tính tổng các chữ số trong số n
        byte sum = 0;
        while (n > 0)
        {
            sum += (byte)(n % 10);
            n /= 10;
        }

        Console.WriteLine($"Tổng các chữ số trong số đó là: {sum}");
    }
}