using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class DictionaryExampleChuong7
    {
        static void Main(string[] args)
        {
            // Tạo một Từ điển với khóa là chuỗi và giá trị là số nguyên
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Thêm một số giá trị cặp khóa vào Từ điển
            myDictionary.Add("Apple", 1);
            myDictionary.Add("Banana", 2);
            myDictionary.Add("Cherry", 3);

            // Kiểm tra xem một khóa có tồn tại trong Từ điển hay không
            string keyToCheck = "Banana";
            if (myDictionary.ContainsKey(keyToCheck))
            {
                Console.WriteLine($"Key '{keyToCheck}' exists in the dictionary.");
            }
            else
            {
                Console.WriteLine($"Key '{keyToCheck}' does not exist in the dictionary.");
            }

            // Sử dụng phương thức TryGetValue để truy xuất giá trị liên kết với một khóa nhất định
            string keyToRetrieve = "Apple";
            if (myDictionary.TryGetValue(keyToRetrieve, out int value))
            {
                Console.WriteLine($"Value associated with key '{keyToRetrieve}' is {value}.");
            }
            else
            {
                Console.WriteLine($"Key '{keyToRetrieve}' not found.");
            }

            // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
            foreach (KeyValuePair<string, int> kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
