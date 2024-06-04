using System;
using System.Text;

class Bai4b
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        long[] arr = new long[n];

        Console.WriteLine("Nhập các phần tử trong mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }

        // Tính tổng các phần tử trong mảng
        long sum = 0;
        foreach (long num in arr)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
    }
}