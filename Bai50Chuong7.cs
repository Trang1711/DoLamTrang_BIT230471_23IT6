using System;
using System.Text;

class Bai50Chuong7
{
    // Hàm generic để tìm giá trị nhỏ nhất trong mảng
    public static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array is null or empty");
        }

        T minValue = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }
        return minValue;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khai báo biến kiểu dynamic
        dynamic min_value;

        // Gọi hàm với mảng số nguyên 4 byte (int)
        int[] intArray = { 4, 2, 7, 1, 9 };
        min_value = FindMinValue(intArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên 4 byte: " + min_value.ToString());

        // Gọi hàm với mảng số nguyên không dấu 4 byte (uint)
        uint[] uintArray = { 10u, 22u, 5u, 7u, 1u };
        min_value = FindMinValue(uintArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên không dấu 4 byte: " + min_value.ToString());

        // Gọi hàm với mảng số thực 4 byte (float)
        float[] floatArray = { 4.5f, 2.2f, 7.8f, 1.1f, 9.3f };
        min_value = FindMinValue(floatArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 4 byte: " + min_value.ToString());

        // Gọi hàm với mảng số thực 8 byte (double)
        double[] doubleArray = { 4.5, 2.2, 7.8, 1.1, 9.3 };
        min_value = FindMinValue(doubleArray);
        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 8 byte: " + min_value.ToString());
    }
}
