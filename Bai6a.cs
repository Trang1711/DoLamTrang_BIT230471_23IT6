using System;
using System.Text;

class Bai6a
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

        // Tính trung bình cộng
        double sum = 0;
        foreach (double num in arr)
        {
            sum += num;
        }
        double avg = sum / n;

        Console.WriteLine($"Trung bình cộng của các phần tử trong mảng là: {avg}");
    }
}