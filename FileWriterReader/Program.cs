using System;
using System.IO;

namespace FileWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            using (StreamWriter file = new StreamWriter("Text.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Wrote to file successfully!\n");
            Console.WriteLine("Now trying to read file:");
            try
            {
                    // Open the text file using a stream reader.
                using (var sr = new StreamReader("Text.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        System.Console.WriteLine("UwU # " + line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
