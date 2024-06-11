using System;
using System.Text;

namespace BaiTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Chọn phần muốn thực hiện:");
                Console.WriteLine("1. Hiển thị bảng mã ASCII");
                Console.WriteLine("2. Hiển thị bảng mã UTF-8 của trang mã 65001");
                Console.WriteLine("3. Phát tiếng beep khi nhấn phím space");
                Console.WriteLine("4. Đếm số lần xuất hiện của mỗi ký tự trong chuỗi");
                Console.WriteLine("5. Nhấn 5 để thoát");
                Console.Write("Nhập lựa chọn (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayASCIITable();
                        break;
                    case 2:
                        DisplayUTF8Table();
                        break;
                    case 3:
                        PlayBeepOnSpacePress();
                        break;
                    case 4:
                        CountCharacters();
                        break;
                    case 5:
                        continueProgram = false;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayASCIITable()
        {
            Console.WriteLine("Bảng mã ASCII:");
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i} - {(char)i}");
            }
        }

        static void DisplayUTF8Table()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bảng mã UTF-8 của trang mã 65001:");
            for (int i = 0; i < 65536; i++)
            {
                Console.WriteLine($"{i} - {(char)i}");
            }
        }

        static void PlayBeepOnSpacePress()
        {
            Console.WriteLine("Nhấn phím space để phát tiếng beep. Nhấn Esc để thoát.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        Console.Beep();
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }

        static void CountCharacters()
        {
            Console.Write("Nhập chuỗi ký tự: ");
            string input = Console.ReadLine();
            int[] charCount = new int[256];

            foreach (char c in input)
            {
                charCount[(int)c]++;
            }

            Console.WriteLine("Số lần xuất hiện của mỗi ký tự:");
            for (int i = 0; i < 256; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine($"{(char)i}: {charCount[i]}");
                }
            }
        }
    }
}