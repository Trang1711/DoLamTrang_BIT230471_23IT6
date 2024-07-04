using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Person obs = new Student("Nguyễn Văn Nam", "ICT");

        if (obs is Student student)
        {
            student.kpi();
        }
        else
        {
            Console.WriteLine("The object is not a Student.");
        }
    }
}
