using System;
using System.Text;

class Bai2a
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        // Nhập các phần tử mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Tìm phần tử lớn nhất và nhỏ nhất trong mảng
        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine($"Số lớn nhất trong dãy là: {max}");
        Console.WriteLine($"Số nhỏ nhất trong dãy là: {min}");
    }
}
