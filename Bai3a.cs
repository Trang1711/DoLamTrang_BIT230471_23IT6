using System;
using System.Text;

class Bai3a
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        ushort[] arr = new ushort[n];

        Console.WriteLine("Nhập các phần tử trong mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = ushort.Parse(Console.ReadLine());
        }

        // Tính tổng các phần tử trong mảng
        ulong sum = 0;
        foreach (ushort num in arr)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
    }
}
