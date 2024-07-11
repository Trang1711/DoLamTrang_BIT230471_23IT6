using System;
using System.Text;
using Newtonsoft.Json; // Đảm bảo rằng bạn đã cài đặt gói Newtonsoft.Json.

namespace TinhToanHinhTron
{
    class ChuongTrinh
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8 ;
            double banKinh;

            // Vòng lặp kiểm tra đầu vào
            while (true)
            {
                Console.Write("Nhập bán kính (r): ");
                string dauVao = Console.ReadLine();

                if (double.TryParse(dauVao, out banKinh) && banKinh > 0)
                {
                    break; // Đầu vào hợp lệ
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số dương.");
                }
            }

            // Gọi hàm và hiển thị kết quả
            string ketQuaJson = TinhTinhChatHinhTron(banKinh);
            Console.WriteLine("Tính chất hình tròn: " + ketQuaJson);
        }

        static string TinhTinhChatHinhTron(double r)
        {
            // Tính diện tích, chu vi, và đường kính
            double dienTich = Math.PI * Math.Pow(r, 2);
            double chuVi = 2 * Math.PI * r;
            double duongKinh = 2 * r;

            // Tạo một đối tượng vô danh để chứa kết quả
            var ketQua = new
            {
                dien_tich = dienTich,
                chu_vi = chuVi,
                duong_kinh = duongKinh
            };

            // Chuyển đối tượng thành chuỗi JSON
            string chuoiJson = JsonConvert.SerializeObject(ketQua);
            return chuoiJson;
        }
    }
}
