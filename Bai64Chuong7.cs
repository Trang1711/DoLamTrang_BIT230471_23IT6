using System;
using System.IO;
using System.Text;

namespace GhiMang2ChieuRaCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo một mảng 2 chiều ví dụ
            float[,] mang = {
                { 1.1f, 2.2f, 3.3f },
                { 4.4f, 5.5f, 6.6f },
                { 7.7f, 8.8f, 9.9f }
            };

            // Tên file CSV
            string tenFile = "mang2chieu.csv";

            // Gọi hàm ghi mảng ra file CSV
            GhiMangRaCSV(mang, tenFile);

            Console.WriteLine($"Mảng đã được ghi ra file {tenFile}");
        }

        static void GhiMangRaCSV(float[,] mang, string tenFile)
        {
            // Sử dụng StreamWriter để ghi file
            using (StreamWriter writer = new StreamWriter(tenFile))
            {
                int soHang = mang.GetLength(0);
                int soCot = mang.GetLength(1);

                for (int i = 0; i < soHang; i++)
                {
                    string dong = "";
                    for (int j = 0; j < soCot; j++)
                    {
                        dong += mang[i, j];
                        if (j < soCot - 1)
                        {
                            dong += ","; // Thêm dấu phẩy giữa các phần tử
                        }
                    }
                    writer.WriteLine(dong); // Ghi dòng vào file
                }
            }
        }
    }
}
