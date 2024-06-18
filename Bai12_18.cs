using System;

namespace BaiTapTongHop
{
    class Bai12_18
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Chọn bài tập (12-18) hoặc nhập 0 để thoát:");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 12:
                            BaiTap12();
                            break;
                        case 13:
                            BaiTap13();
                            break;
                        case 14:
                            BaiTap14();
                            break;
                        case 15:
                            BaiTap15();
                            break;
                        case 16:
                            BaiTap16();
                            break;
                        case 17:
                            BaiTap17();
                            break;
                        case 18:
                            BaiTap18();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                }
            }
        }

        static void BaiTap12()
        {
            ushort n = NhapSoNguyen2Byte();
            Console.WriteLine($"Giá trị được nhập: {n}");
            int tongBinhPhuong = TinhTongBinhPhuong(n);
            Console.WriteLine($"Tổng bình phương các số từ 1 đến {n}: {tongBinhPhuong}");
        }

        static ushort NhapSoNguyen2Byte()
        {
            ushort n;
            while (true)
            {
                Console.Write("Nhập số nguyên 2 byte không dấu: ");
                if (ushort.TryParse(Console.ReadLine(), out n))
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return n;
        }

        static int TinhTongBinhPhuong(ushort n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        static void BaiTap13()
        {
            byte n = NhapSoNguyen1Byte();
            Console.WriteLine($"Giá trị được nhập: {n}");
        }

        static byte NhapSoNguyen1Byte()
        {
            byte n;
            while (true)
            {
                Console.Write("Nhập số nguyên 1 byte không dấu (2-10): ");
                if (byte.TryParse(Console.ReadLine(), out n) && n >= 2 && n <= 10)
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return n;
        }

        static void BaiTap14()
        {
            float x = NhapSoThuc4Byte();
            Console.WriteLine($"Giá trị được nhập: {x}");
        }

        static float NhapSoThuc4Byte()
        {
            float x;
            while (true)
            {
                Console.Write("Nhập số thực 4 byte: ");
                if (float.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return x;
        }

        static void BaiTap15()
        {
            byte n = NhapSoNguyen1Byte();
            Console.WriteLine($"Giá trị được nhập: {n}");

            float[] a = new float[n];
            NhapMangSoThuc(a, n);

            Console.WriteLine("Các phần tử của mảng:");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        static void NhapMangSoThuc(float[] a, byte n)
        {
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    if (float.TryParse(Console.ReadLine(), out a[i]))
                        break;
                    else
                        Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
                }
            }
        }

        static void BaiTap16()
        {
            byte m = NhapSoNguyen1Byte("m");
            byte n = NhapSoNguyen1Byte("n");
            Console.WriteLine($"Giá trị m được nhập: {m}");
            Console.WriteLine($"Giá trị n được nhập: {n}");

            int[,] a = new int[m, n];
            NhapMangSoNguyen(a, m, n);

            Console.WriteLine("Các phần tử của mảng:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }

            int tong = TinhTongPhanTuChiaHet(a, m, n, 2024);
            Console.WriteLine($"Tổng các phần tử chia hết cho 2024: {tong}");
        }

        static byte NhapSoNguyen1Byte(string varName)
        {
            byte n;
            while (true)
            {
                Console.Write($"Nhập số nguyên 1 byte không dấu ({varName} trong khoảng 2-10): ");
                if (byte.TryParse(Console.ReadLine(), out n) && n >= 2 && n <= 10)
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return n;
        }

        static int NhapSoNguyen4Byte()
        {
            int x;
            while (true)
            {
                Console.Write("Nhập số nguyên 4 byte: ");
                if (int.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return x;
        }

        static void NhapMangSoNguyen(int[,] a, byte m, byte n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhập phần tử a[{i}, {j}]: ");
                    a[i, j] = NhapSoNguyen4Byte();
                }
            }
        }

        static int TinhTongPhanTuChiaHet(int[,] a, byte m, byte n, int p)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] % p == 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }

        static void BaiTap17()
        {
            string st;
            Console.Write("Nhập xâu kí tự: ");
            st = Console.ReadLine();

            if (st == "#")
            {
                Console.Beep();
            }
            else
            {
                int soTu = DemSoTu(st);
                Console.WriteLine($"Số từ trong xâu '{st}': {soTu}");
            }
        }

        static int DemSoTu(string st)
        {
            string[] words = st.Split(new char[] { ' ', '.', '!', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void BaiTap18()
        {
            double x = NhapSoThuc8Byte();
            Console.WriteLine($"Giá trị được nhập: {x}");
            Console.WriteLine($"Căn bậc 2 của {x}: {Math.Sqrt(x)}");
        }

        static double NhapSoThuc8Byte()
        {
            double x;
            while (true)
            {
                Console.Write("Nhập số thực 8 byte: ");
                if (double.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Giá trị không hợp lệ, vui lòng nhập lại.");
            }
            return x;
        }
    }
}
