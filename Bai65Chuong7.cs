using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GhiDictionaryRaCSV
{
    class Bai65Chuong7
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

            // Tên file CSV
            string tenFile = "dictionary.csv";

            // Gọi hàm ghi dictionary ra file CSV
            GhiDictionaryRaCSV(dict, tenFile);

            Console.WriteLine($"Dictionary đã được ghi ra file {tenFile}");
        }

        static void GhiDictionaryRaCSV(Dictionary<string, double> dict, string tenFile)
        {
            // Sử dụng StreamWriter để ghi file
            using (StreamWriter writer = new StreamWriter(tenFile))
            {
                // Ghi header
                writer.WriteLine("Key,Value");

                // Ghi các phần tử trong dictionary
                foreach (var item in dict)
                {
                    writer.WriteLine($"{item.Key},{item.Value}");
                }
            }
        }
    }
}
