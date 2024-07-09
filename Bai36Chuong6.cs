using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// a. Tạo lớp trừu tượng Person
public abstract class Person
{
    private string name;
    private string id;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Id
    {
        get { return id; }
        set
        {
            // Kiểm tra mã sinh viên id phải có độ dài 8 và đều là kí tự số
            if (value.Length == 8 && value.All(char.IsDigit))
            {
                id = value;
            }
            else
            {
                throw new ArgumentException("Mã sinh viên phải có độ dài 8 kí tự và đều là kí tự số.");
            }
        }
    }
}

// b. Tạo interface Kpi
public interface Kpi
{
    float kpi();
}

// c. Tạo lớp Student kế thừa từ Person và implement interface Kpi
public class Student : Person, Kpi
{
    private string department;

    public string Department
    {
        get { return department; }
        set
        {
            // Department phải thuộc ["ICT", "ECO"]
            if (value == "ICT" || value == "ECO")
            {
                department = value;
            }
            else
            {
                throw new ArgumentException("Department phải thuộc [\"ICT\", \"ECO\"].");
            }
        }
    }

    public float kpi()
    {
        // Giả sử điểm GPA được tính ở đây
        // Trả về một giá trị float ví dụ 8.5
        return 8.5f; // Đây là giá trị mẫu, bạn cần thay đổi tùy theo logic thực tế
    }
}

class Bai36Chuong6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // d. Khai báo và cấp phát obs là Student và gán null
        Person obs = null;

        // e. Cấp phát obs là Student có name là "Nguyễn Tiến Dũng", id là "12345678", department là "ICT". Hiển thị kpi()
        try
        {
            obs = new Student();
            obs.Name = "Nguyễn Tiến Dũng";
            obs.Id = "12345678";
            ((Student)obs).Department = "ICT";

            Console.WriteLine("KPI của sinh viên: " + ((Student)obs).kpi());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi khi cấp phát sinh viên: " + ex.Message);
        }

        // g. Cấp phát obs bị sai về id hoặc department và xem hiệu ứng
        try
        {
            obs = new Student();
            obs.Name = "Nguyễn Văn A"; // Name có thể là bất kỳ
            obs.Id = "12345"; // Id không đủ 8 ký tự
            ((Student)obs).Department = "ABC"; // Department không hợp lệ

            Console.WriteLine("KPI của sinh viên: " + ((Student)obs).kpi()); // Dòng này sẽ không được thực thi vì lỗi phát sinh trước đó
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi khi cấp phát sinh viên: " + ex.Message);
        }

        // h. Khai báo các biến danh sách list1, list2 các đối tượng Person
        List<Person> list1 = new List<Person>();
        List<Person> list2 = new List<Person>();

        // Nhập vào từ bàn phím list1 các sinh viên ngồi bàn 1 lớp 23IT5 ngày 25/06/2024
        Console.WriteLine("Nhập danh sách sinh viên cho list1 (kết thúc nhập nếu name là #):");
        string inputName;
        do
        {
            Console.Write("Tên sinh viên: ");
            inputName = Console.ReadLine().Trim();
            if (inputName != "#")
            {
                try
                {
                    Person student = new Student();
                    student.Name = inputName;
                    student.Id = "12345678"; // Giả sử id mặc định
                    ((Student)student).Department = "ICT"; // Giả sử department mặc định
                    list1.Add(student);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thêm sinh viên vào list1: " + ex.Message);
                }
            }
        } while (inputName != "#");

        // Nhập vào từ bàn phím list2 các sinh viên ngồi bàn 2 lớp 23IT6 ngày 25/06/2024
        Console.WriteLine("Nhập danh sách sinh viên cho list2 (kết thúc nhập nếu name là #):");
        do
        {
            Console.Write("Tên sinh viên: ");
            inputName = Console.ReadLine().Trim();
            if (inputName != "#")
            {
                try
                {
                    Person student = new Student();
                    student.Name = inputName;
                    student.Id = "12345678"; // Giả sử id mặc định
                    ((Student)student).Department = "ECO"; // Giả sử department mặc định
                    list2.Add(student);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thêm sinh viên vào list2: " + ex.Message);
                }
            }
        } while (inputName != "#");

        // Hiển thị list1 và list2
        Console.WriteLine("\nDanh sách sinh viên list1:");
        foreach (var student in list1)
        {
            Console.WriteLine($"Tên: {student.Name}, ID: {student.Id}, Department: {(student is Student ? ((Student)student).Department : "N/A")}");
        }

        Console.WriteLine("\nDanh sách sinh viên list2:");
        foreach (var student in list2)
        {
            Console.WriteLine($"Tên: {student.Name}, ID: {student.Id}, Department: {(student is Student ? ((Student)student).Department : "N/A")}");
        }

        // k. Khai báo 1 list_list kiểu List của List, và bổ sung list1, list2 vào list_list
        List<List<Person>> list_list = new List<List<Person>>();
        list_list.Add(list1);
        list_list.Add(list2);

        // Hiển thị list_list
        Console.WriteLine("\nDanh sách list_list:");
        for (int i = 0; i < list_list.Count; i++)
        {
            Console.WriteLine($"\nDanh sách {i + 1}:");
            foreach (var student in list_list[i])
            {
                Console.WriteLine($"Tên: {student.Name}, ID: {student.Id}, Department: {(student is Student ? ((Student)student).Department : "N/A")}");
            }
        }

        // l. Tạo Dictionary dic11 cho list1 Student với trường khóa id và tìm trong dict1 bạn có tên là "Nam"
        Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
        foreach (var student in list1)
        {
            if (student is Student)
            {
                dic11[((Student)student).Id] = (Student)student;
            }
        }

        // Tìm trong dic11 bạn có tên là "Nam" và hiển thị
        Console.WriteLine("\nTìm sinh viên có tên là Nam trong dic11:");
        bool found = false;
        foreach (var student in dic11.Values)
        {
            if (student.Name.Contains("Nam"))
            {
                Console.WriteLine($"Tên: {student.Name}, ID: {student.Id}, Department: {student.Department}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Không tìm thấy sinh viên có tên là Nam trong dic11.");
        }
    }
}
