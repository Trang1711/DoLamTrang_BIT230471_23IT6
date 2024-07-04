using System.Xml.Linq;

public class Student : Person, KPI
{
    public string Major { get; set; }

    public Student(string name, string major)
    {
        Name = name;
        Major = major;
    }

    public void kpi()
    {
        Console.WriteLine($"KPI of student {Name}, majoring in {Major}.");
    }
}
