using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class Bai48Chuong7
{
    static void Main()
    {
        Console.OutputEncoding= Encoding.UTF8 ;
        Dictionary<string, double> dict1 = new Dictionary<string, double>();
        while (true)
        {
            Console.WriteLine("Nhập ID sinh viên (nhập '#' để dừng): ");
            string id = Console.ReadLine();

            if (id == "#")
            {
                break;
            }

            Console.WriteLine("Nhập điểm trung bình (GPA): ");
            string gpaInput = Console.ReadLine();

            if (double.TryParse(gpaInput, out double gpa) && gpa >= 0 && gpa <= 4)
            {
                if (!dict1.ContainsKey(id))
                {
                    dict1.Add(id, gpa);
                }
                else
                {
                    Console.WriteLine($"ID '{id}' đã tồn tại. Vui lòng nhập ID khác.");
                }
            }
            else
            {
                Console.WriteLine("Điểm trung bình không hợp lệ. Vui lòng nhập lại.");
            }
        }

        Console.WriteLine("Nhập ID sinh viên cần tra cứu điểm trung bình: ");
        string searchID = Console.ReadLine();

        if (dict1.TryGetValue("123456", out double resultGPA))
        {
            Console.WriteLine($"Điểm trung bình của sinh viên có ID '123456' là {resultGPA}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có ID '123456'.");
        }
    }
}
