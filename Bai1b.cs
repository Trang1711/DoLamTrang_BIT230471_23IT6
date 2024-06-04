using System;
using System.Text;
namespace arraySum
{
    class Bai1b
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // nhập các phần tử mảng
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử {0}:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            // tính tổng 
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Tổng các phần tử trong mảng: {0}", sum);
        }
    }
}
