using System;
using System.Text;

public abstract class Shape
{
    private int soDinh;
    public int SoDinh
    {
        get { return soDinh; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Số đỉnh phải lớn hơn 0.");
            }
            soDinh = value;
        }
    }
}

public class TamGiac : Shape
{
    public TamGiac()
    {
        SoDinh = 3; // Số đỉnh của tam giác luôn là 3
    }

    public void Display()
    {
        Console.WriteLine($"Đây là một hình tam giác với {SoDinh} đỉnh.");
    }
}

class Bai35_Chuong6
{
 
    static void Main(string[] args)
    {
        Console.OutputEncoding= Encoding.UTF8;
        try
        {
            TamGiac tg = new TamGiac();
            tg.Display();

            // Kiểm tra với số đỉnh không hợp lệ
            // Shape hinh = new TamGiac();
            // hinh.SoDinh = 4; // Điều này sẽ ném ra ArgumentException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
