using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        string fileName = "data.json";
        Dictionary<string, object> dictionary = ReadJsonFileSystemTextJson(fileName);

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    public static Dictionary<string, object> ReadJsonFileSystemTextJson(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        return dictionary;
    }
}

/*Cách 2
 * using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        string fileName = "data.json";
        Dictionary<string, object> dictionary = ReadJsonFileNewtonsoftJson(fileName);
        
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    public static Dictionary<string, object> ReadJsonFileNewtonsoftJson(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
        return dictionary;
    }
}
*/