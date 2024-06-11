using System;
using System.IO;
using System.Text;

namespace Baitap11
{
    class Baitap11
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tên file: ");
            string fileName = Console.ReadLine();

            Console.WriteLine("Nhập nội dung file (nhấn Enter khi hoàn tất):");
            string content = "";
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                content += line + Environment.NewLine;
            }

            try
            {
                // Ghi nội dung vào file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(content);
                }

                // Đọc nội dung từ file
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine("\nNội dung file:");
                    Console.WriteLine(fileContent);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Lỗi khi đọc/ghi file: " + e.Message);
            }
        }
    }
}