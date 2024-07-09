using System;
using System.Collections.Generic;
using System.Text;

class Bai41Chuong6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<List<string>> myList = new List<List<string>>();

        // Thêm các danh sách con vào myList
        myList.Add(new List<string> { "a", "b" });
        myList.Add(new List<string> { "c", "d", "e" });
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });

        // Duyệt danh sách myList và in ra từng phần tử
        for (int i = 0; i < myList.Count; i++)
        {
            List<string> subList = myList[i];
            for (int j = 0; j < subList.Count; j++)
            {
                string item = subList[j];
                Console.WriteLine(item);
            }
        }
    }
}
