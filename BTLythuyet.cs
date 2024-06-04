using System;
using System.Text;

class BTLythuyet
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Exercise 1
        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Số này là số dương.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Số này là số âm.");
        }
        else
        {
            Console.WriteLine("Số này bằng 0.");
        }

        // Exercise 2
        Console.Write("Nhập ngày trong tuần (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        string dayName;
        switch (dayNumber)
        {
            case 1:
                dayName = "Thứ Hai";
                break;
            case 2:
                dayName = "Thứ Ba";
                break;
            case 3:
                dayName = "Thứ Tư";
                break;
            case 4:
                dayName = "Thứ Năm";
                break;
            case 5:
                dayName = "Thứ Sáu";
                break;
            case 6:
                dayName = "Thứ Bảy";
                break;
            case 7:
                dayName = "Chủ Nhật";
                break;
            default:
                dayName = "Ngày không hợp lệ";
                break;
        }

        Console.WriteLine("Ngày trong tuần là: " + dayName);

        // Exercise 3
        Console.Write("Nhập một số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Giai thừa của " + n + " là: " + factorial);

        // Exercise 4
        Console.Write("Nhập số hàng: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột: ");
        int columns = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Exercise 5
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess;

        Console.WriteLine("Đoán số bí mật từ 1 đến 100.");

        while (true)
        {
            Console.Write("Số đoán của bạn: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Chúc mừng! Bạn đã đoán đúng số bí mật.");
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Số bí mật lớn hơn.");
            }
            else
            {
                Console.WriteLine("Số bí mật nhỏ hơn.");
            }
        }

        // Exercise 6
        int sum = 0;

        Console.WriteLine("Nhập một dãy số (để kết thúc, nhập số âm):");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                break;
            }
            else if (num > 0)
            {
                sum += num;
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine("Tổng của các số dương là: " + sum);
    }
}