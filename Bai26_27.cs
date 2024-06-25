using System;
using System.Text;

// Bài tập 26
public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract override string ToString();
}

public class Student : Person, KPI
{
    public string Major { get; set; }
    public float GPA { get; set; }

    public Student(string name, int age, string major, float gpa)
        : base(name, age)
    {
        Major = major;
        GPA = gpa;
    }

    public override string ToString()
    {
        return $"Tên: {Name}, Tuổi: {Age}, Ngành: {Major}, GPA: {GPA}";
    }

    public double CalculateKPI()
    {
        return GPA;
    }
}

// Bài tập 27
public interface KPI
{
    double CalculateKPI();
}

public class Teacher : Person, KPI
{
    public string Major { get; set; }
    public int Publications { get; set; }

    public Teacher(string name, int age, string major, int publications)
        : base(name, age)
    {
        Major = major;
        Publications = publications;
    }

    public override string ToString()
    {
        return $"Tên: {Name}, Tuổi: {Age}, Ngành: {Major}, Số lượng bài báo: {Publications}";
    }

    public double CalculateKPI()
    {
        return Publications * 1.5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo đối tượng sinh viên
        Student student = new Student("Nguyễn Tiến Dũng", 20, "CNTT&TT", 3.8f);
        // Tạo đối tượng giáo viên
        Teacher teacher = new Teacher("Vũ Đức Việt", 38, "CNTT&TT", 5);

        // Hiển thị thông tin và KPI của đối tượng sinh viên
        Console.WriteLine(student.ToString());
        Console.WriteLine($"KPI của sinh viên: {student.CalculateKPI()}");

        // Hiển thị thông tin và KPI của đối tượng giáo viên
        Console.WriteLine(teacher.ToString());
        Console.WriteLine($"KPI của giáo viên: {teacher.CalculateKPI()}");
    }
}
