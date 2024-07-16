using System;
using System.IO;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        // Part a: Operations with Program.cs file
        string programFilePath = "Program.cs";
        int numberOfLines = CountLines(programFilePath);
        Console.WriteLine($"Number of lines in {programFilePath}: {numberOfLines}");

        char targetChar = 'a';
        int charCount = CountCharacters(programFilePath, targetChar);
        Console.WriteLine($"Number of '{targetChar}' characters in {programFilePath}: {charCount}");

        int wordCount = CountWords(programFilePath);
        Console.WriteLine($"Number of words in {programFilePath}: {wordCount}");

        // Part b: Read and Write UTF-8 Text Files
        string utf8ReadFilePath = "vd1_read.txt";
        string utf8WriteFilePath = "vd1_ghi.txt";
        string utf8Content = ReadFile(utf8ReadFilePath, Encoding.UTF8);
        WriteFile(utf8WriteFilePath, utf8Content, Encoding.UTF8);

        // Part c: Read and Write UTF-16 Text Files
        string utf16ReadFilePath = "vd1_read.txt"; // Assuming it's UTF-16 encoded
        string utf16WriteFilePath = "vd1_ghi.txt"; // Writing as UTF-16
        string utf16Content = ReadFile(utf16ReadFilePath, Encoding.Unicode);
        WriteFile(utf16WriteFilePath, utf16Content, Encoding.Unicode);

        // Part d: Read and Write Double-precision Floating Point Numbers to Binary File
        string binaryFilePath = "a2d.dat";
        double[,] arrayToWrite = { { 1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 } };
        WriteDoubleArrayToFile(binaryFilePath, arrayToWrite);
        double[,] arrayToRead = ReadDoubleArrayFromFile(binaryFilePath);

        // Optional: Print the read array for verification
        if (arrayToRead != null)
        {
            Console.WriteLine("Array read from binary file:");
            PrintDoubleArray(arrayToRead);
        }
    }

    // Function to count lines in a file
    static int CountLines(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return 0;
        }
    }

    // Function to count specific characters in a file
    static int CountCharacters(string filePath, char targetChar)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            int count = content.Count(c => c == targetChar);
            return count;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return 0;
        }
    }

    // Function to count words separated by spaces in a file
    static int CountWords(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return 0;
        }
    }

    // Function to read a file with specified encoding
    static string ReadFile(string filePath, Encoding encoding)
    {
        try
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return string.Empty;
        }
    }

    // Function to write content to a file with specified encoding
    static void WriteFile(string filePath, string content, Encoding encoding)
    {
        try
        {
            File.WriteAllText(filePath, content, encoding);
            Console.WriteLine($"Successfully wrote to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing file: {ex.Message}");
        }
    }

    // Function to write a double array to a binary file
    static void WriteDoubleArrayToFile(string filePath, double[,] array)
    {
        try
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                writer.Write(rows);
                writer.Write(cols);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(array[i, j]);
                    }
                }

                Console.WriteLine($"Successfully wrote array to {filePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing file: {ex.Message}");
        }
    }

    // Function to read a double array from a binary file
    static double[,] ReadDoubleArrayFromFile(string filePath)
    {
        try
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int rows = reader.ReadInt32();
                int cols = reader.ReadInt32();

                double[,] array = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = reader.ReadDouble();
                    }
                }

                Console.WriteLine($"Successfully read array from {filePath}");
                return array;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return null;
        }
    }

    // Function to print a double array
    static void PrintDoubleArray(double[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
