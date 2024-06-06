using System;
using System.Text;

namespace CSharpNumberExercises
{
    class Bai7_Luyentapkieuso
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8 ;
            bool running = true;
            while (running)
            {
                Console.WriteLine("Chọn bài tập (a-m) hoặc 'q' để thoát:");
                char choice = Console.ReadLine().ToLower()[0];

                switch (choice)
                {
                    case 'a':
                        SumTwoUnsignedInts();
                        break;
                    case 'b':
                        RectangleAreaPerimeter();
                        break;
                    case 'c':
                        CheckEvenOdd();
                        break;
                    case 'd':
                        SumTwoSignedBytes();
                        break;
                    case 'e':
                        SumUpToN();
                        break;
                    case 'g':
                        RectangleAreaPerimeterDouble();
                        break;
                    case 'h':
                        FindLargest();
                        break;
                    case 'k':
                        Factorial();
                        break;
                    case 'l':
                        CheckPrime();
                        break;
                    case 'm':
                        CheckPerfectNumber();
                        break;
                    case 'q':
                        running = false;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // a)Viết một chương trình nhận vào hai số nguyên không dấu từ người dùng
        // và tính tổng của chúng. In kết quả lên màn hình.
        static void SumTwoUnsignedInts()
        {
            Console.Write("Nhập số nguyên không dấu thứ nhất: ");
            uint num1 = uint.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên không dấu thứ hai: ");
            uint num2 = uint.Parse(Console.ReadLine());
            uint sum = num1 + num2;
            Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
        }

        //b) Viết một chương trình nhận vào chiều dài và chiều rộng của một hình chữ nhật từ người dùng là số nguyên 2 byte không dấu.
        //Tính diện tích và chu vi của hình chữ nhật đó. In kết quả lên màn hình.
        static void RectangleAreaPerimeter()
        {
            Console.Write("Nhập chiều dài hình chữ nhật (2 byte không dấu): ");
            ushort length = ushort.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình chữ nhật (2 byte không dấu): ");
            ushort width = ushort.Parse(Console.ReadLine());
            ushort area = (ushort)(length * width);
            ushort perimeter = (ushort)((length + width) * 2);
            Console.WriteLine($"Diện tích của hình chữ nhật là: {area}");
            Console.WriteLine($"Chu vi của hình chữ nhật là: {perimeter}");
        }

        //c). Viết một chương trình nhận vào một số nguyên không dấu 4byte từ người dùng
        //và kiểm tra xem số đó là chẵn hay lẻ. In kết quả lên màn hình.
        static void CheckEvenOdd()
        {
            Console.Write("Nhập số nguyên không dấu (4 byte): ");
            uint num = uint.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{num} là số lẻ");
            }
        }

        //d) Viết một chương trình nhận vào hai số nguyên có dấu 1byte từ người dùng
        //và tính tổng của chúng. In kết quả lên màn hình.
        static void SumTwoSignedBytes()
        {
            Console.Write("Nhập số nguyên có dấu thứ nhất (1 byte): ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên có dấu thứ hai (1 byte): ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());
            sbyte sum = (sbyte)(num1 + num2);
            Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
        }

        // e.Viết một chương trình nhận vào một số nguyên n không dấu 4byte từ người dùng
        // và tính tổng của các số từ 1 đến n.In kết quả lên màn hình.
        static void SumUpToN()
        {
            Console.Write("Nhập số nguyên không dấu (4 byte): ");
            uint n = uint.Parse(Console.ReadLine());
            uint sum = (uint)(n * (n + 1)) / 2;
            Console.WriteLine($"Tổng của các số từ 1 đến {n} là: {sum}");
        }

        //g. Viết một chương trình nhận vào chiều dài và chiều rộng kiểu số thwucj 8 byte
        //của một hình chữ nhật từ người dùng. Tính diện tích và chu vi của hình chữ nhật đó. In kết quả lên màn hình.
        static void RectangleAreaPerimeterDouble()
        {
            Console.Write("Nhập chiều dài hình chữ nhật (8 byte): ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng hình chữ nhật (8 byte): ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Diện tích của hình chữ nhật là: {area}");
            Console.WriteLine($"Chu vi của hình chữ nhật là: {perimeter}");
        }

        //h) h. Viết một chương trình nhận vào ba số nguyên từ người dùng và tìm số lớn nhất trong ba số đó. In kết quả lên màn hình.
        static void FindLargest()
        {
            Console.Write("Nhập số nguyên thứ nhất: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên thứ hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên thứ ba: ");
            int num3 = int.Parse(Console.ReadLine());
            int largest = Math.Max(Math.Max(num1, num2), num3);
            Console.WriteLine($"Số lớn nhất trong ba số là: {largest}");
        }
        //k. Viết một chương trình nhận vào một số nguyên không âm n từ người dùng
        //và tính giai thừa của số đó. In kết quả lên màn hình.
        static void Factorial()
        {
            Console.Write("Nhập số nguyên không âm: ");
            uint n = uint.Parse(Console.ReadLine());
            uint factorial = 1;
            for (uint i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Giai thừa của {n} là: {factorial}");
        }

       // l.Viết một chương trình nhận vào một số nguyên không âm n từ người dùng
       // và kiểm tra xem số đó có phải là số nguyên tố hay không.In kết quả lên màn hình.
        static void CheckPrime()
        {
            Console.Write("Nhập số nguyên không âm: ");
            uint n = uint.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (uint i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố");
            }
        }
        // m. Viết một chương trình nhận vào một số nguyên từ người dùng và kiểm tra xem số đó
        // có phải là số hoàn hảo hay không. Số hoàn hảo là số mà tổng các ước số của nó (không tính chính nó) bằng chính nó
        static void CheckPerfectNumber()
        {
            Console.Write("Nhập số nguyên không âm: ");
            uint n = uint.Parse(Console.ReadLine());
            uint sum = 0;
            for (uint i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"{n} là số hoàn hảo");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số hoàn hảo");
            }
        }
    }
}