

// Đồng bộ sử dụng Thread.Sleep
using System;
using System.Text;
using System.Threading;

class Bai81Chuong7
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Sử dụng Thread.Sleep:");
        Console.WriteLine("Start");
        Thread.Sleep(100); // Tạm dừng luồng hiện tại trong 100ms
        Console.WriteLine("End");

        // Chạy không đồng bộ sử dụng Task.Delay
        RunAsync().Wait();
        Console.ReadLine();
    }

    static async Task RunAsync()
    {
        Console.WriteLine("\nSử dụng Task.Delay:");
        Console.WriteLine("Start");
        await Task.Delay(100); // Không chặn luồng hiện tại, tiếp tục sau 100ms
        Console.WriteLine("End");
    }
}