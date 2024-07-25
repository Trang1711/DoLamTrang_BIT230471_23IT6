
using System.Threading;

class Bai80Chuong7
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(ff);
        thread.Start();

        // Đợi cho luồng hoàn thành
        thread.Join();

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }

    public static void ff()
    {
        Random random = new Random();
        while (true)
        {
            int n = random.Next();
            if (n % 2025 == 0)
            {
                break;
            }
            Console.WriteLine(n);
            Thread.Sleep(100); // Delay 100ms
        }
    }
}