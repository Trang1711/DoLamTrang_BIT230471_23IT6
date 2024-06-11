using System;
using System.Text;

namespace Baitap10
{
    struct Student
    {
        public string Name;
        public float Score;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            // Nhập thông tin sinh viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sinh viên {i + 1}:");
                Console.Write("Tên: ");
                students[i].Name = Console.ReadLine();
                Console.Write("Điểm: ");
                students[i].Score = float.Parse(Console.ReadLine());
            }

            // Hiển thị thông tin sinh viên và tính điểm trung bình
            float totalScore = 0;
            Console.WriteLine("\nThông tin sinh viên:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tên: {students[i].Name}, Điểm: {students[i].Score}");
                totalScore += students[i].Score;
            }
            float averageScore = totalScore / n;
            Console.WriteLine($"\nĐiểm trung bình của lớp: {averageScore}");
        }
    }
}