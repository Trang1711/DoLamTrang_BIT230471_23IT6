using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace GhiDictionaryRaJSON
{
    class Bai63Chuong7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8 ;
            // Tạo một Dictionary ví dụ
            Dictionary<string, double> dict = new Dictionary<string, double>
            {
                { "Key1", 1.1 },
                { "Key2", 2.2 },
                { "Key3", 3.3 },
                { "Key4", 4.4 },
                { "Key5", 5.5 }
            };

            // Tên file JSON
            string tenFile = "dictionary.json";

            // Gọi hàm ghi dictionary ra file JSON và nhận lại giá trị trả về
            bool result = GhiDictionaryRaJSON(dict, tenFile);

            // Kiểm tra kết quả
            if (result)
            {
                Console.WriteLine($"Dictionary đã được ghi ra file {tenFile} thành công.");
            }
            else
            {
                Console.WriteLine($"Ghi dictionary ra file {tenFile} thất bại.");
            }
        }

        static bool GhiDictionaryRaJSON(Dictionary<string, double> dict, string tenFile)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(dict);
                File.WriteAllText(tenFile, jsonString);
                return true; // Trả lại giá trị true nếu thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false; // Trả lại giá trị false nếu có lỗi
            }
        }
    }
}
