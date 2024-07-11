using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocFileCSV_VaoMang2Chieu
{
    class Bai66Chuong7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tên file CSV
            string tenFile = "data.csv";

            // Gọi hàm đọc file CSV và nhận mảng 2 chiều
            double[,] mang2Chieu = DocFileCSV(tenFile);

            // Kiểm tra và hiển thị mảng 2 chiều
            if (mang2Chieu != null)
            {
                Console.WriteLine("Dữ liệu từ file CSV:");
                HienThiMang2Chieu(mang2Chieu);
            }
            else
            {
                Console.WriteLine($"Không thể đọc dữ liệu từ file {tenFile}");
            }
        }

        static double[,] DocFileCSV(string tenFile)
        {
            try
            {
                // Đọc toàn bộ nội dung từ file CSV
                string[] lines = File.ReadAllLines(tenFile);

                // Xác định số hàng và số cột của mảng 2 chiều
                int soHang = lines.Length;
                int soCot = lines[0].Split(',').Length;

                // Tạo mảng 2 chiều để lưu trữ dữ liệu
                double[,] mang2Chieu = new double[soHang, soCot];

                // Duyệt từng dòng trong file CSV
                for (int i = 0; i < soHang; i++)
                {
                    string[] values = lines[i].Split(',');

                    // Duyệt từng giá trị trong dòng và gán vào mảng 2 chiều
                    for (int j = 0; j < soCot; j++)
                    {
                        mang2Chieu[i, j] = Convert.ToDouble(values[j]);
                    }
                }

                return mang2Chieu;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file CSV: {ex.Message}");
                return null;
            }
        }

        static void HienThiMang2Chieu(double[,] mang)
        {
            int soHang = mang.GetLength(0);
            int soCot = mang.GetLength(1);

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(mang[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
