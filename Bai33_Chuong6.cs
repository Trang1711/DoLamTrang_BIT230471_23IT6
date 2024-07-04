using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Student { Name = "Nguyễn Văn Nam", Major = "ICT" };

        if (person is Student student)
        {
            student.kpi();
        }

        try
        {
            person.Name = ""; // Điều này sẽ ném ra ArgumentException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
