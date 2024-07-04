public class Person
{
    public virtual void Display()
    {
        Console.WriteLine("This is a person.");
    }
}

public class Student : Person
{
    public override void Display()
    {
        Console.WriteLine("This is a student.");
    }
}
// 