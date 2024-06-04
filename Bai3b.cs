using System;
using System.Text;

class Bai3b
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        short[] arr = new short[n];

        Console.WriteLine("Nhập các phần tử trong mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = short.Parse(Console.ReadLine());
        }

        // Tính tổng các phần tử trong mảng
        long sum = 0;
        foreach (short num in arr)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
    }
}