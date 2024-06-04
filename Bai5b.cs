using System;
using System.Text;

class Bai5b
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());

        float[] arr = new float[n];

        Console.WriteLine("Nhập các phần tử trong mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = float.Parse(Console.ReadLine());
        }

        // Tính tổng các phần tử trong mảng
        float sum = 0;
        foreach (float num in arr)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
    }
}
