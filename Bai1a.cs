using System;
using System.Text;
namespace checkNumber
{
    class Bai1a
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            // nhập vào a
            Console.WriteLine("Nhập vào một số nguyên a (4byte): ");
            while (!int.TryParse(System.Console.ReadLine(), out a))
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại:");
            }
            // nhập vào b
            Console.WriteLine("Nhập vào một số nguyên b (4byte): ");
            while (!int.TryParse(System.Console.ReadLine(), out b))
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại:");
            }
            // tính
            int s = a + b;
            int diff = a - b;
            int product = a * b;
            int quo = a / b;
            double realquo = (double)a / b;
            // in kết quả
            Console.WriteLine($"Tổng: {s}");
            Console.WriteLine($"Hiệu: {diff}");
            Console.WriteLine($"Tích: {product}");
            Console.WriteLine($"Thương (số nguyên): {quo}");
            Console.WriteLine($"Thương (số thực): {realquo}");
        }
    }
}

