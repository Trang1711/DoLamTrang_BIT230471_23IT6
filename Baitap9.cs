using System;
using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Chọn chức năng:");
                Console.WriteLine("a. Đảo ngược chuỗi");
                Console.WriteLine("b. Đếm số từ trong chuỗi");
                Console.WriteLine("c. Nhấn c để thoát:");
                Console.Write("Nhập lựa chọn (a hoặc b): ");
               
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        ReverseString();
                        break;
                    case "b":
                        CountWords();
                        break;
                    case "c":
                        continueProgram = false;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ReverseString()
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            string reversed = ReverseStringHelper(input);
            Console.WriteLine("Chuỗi đảo ngược: " + reversed);
        }

        static string ReverseStringHelper(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void CountWords()
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            int wordCount = CountWordsHelper(input);
            Console.WriteLine("Số từ trong chuỗi: " + wordCount);
        }

        static int CountWordsHelper(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}