using System;
using System.Text;

class Bai6b
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];

        Console.WriteLine("Nhập các phần tử trong mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }

        // Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        double max = arr[0];
        double min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
    }
}