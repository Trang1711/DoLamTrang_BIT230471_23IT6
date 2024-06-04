using System;
using System.Text;

class Bai2b
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        sbyte[] arr = new sbyte[n];

        // Nhập các phần tử mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử {i + 1}: ");
            arr[i] = sbyte.Parse(Console.ReadLine());
        }

        // Tính tổng các số chẵn
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
                sum += arr[i];
        }

        Console.WriteLine($"Tổng các số chẵn trong dãy là: {sum}");
    }
}
