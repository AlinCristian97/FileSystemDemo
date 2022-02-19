using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var currentDirectory = new DirectoryInfo(".");
            var alinDirectory = new DirectoryInfo(@"C:\Users\Alin-PC");

            Console.WriteLine(alinDirectory.FullName);
            Console.WriteLine(alinDirectory.Name);
            Console.WriteLine(alinDirectory.Parent);
            Console.WriteLine(alinDirectory.Attributes);
            Console.WriteLine(alinDirectory.CreationTime);

            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string path = @"E:\Temp\Demos\FileSystem\FileIO";
            string textFilePath = @"E:\Temp\Demos\FileSystem\FileIO\test.txt";
            
            File.WriteAllLines(textFilePath, customers);

            foreach (string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer: {customer}");
            }

            var myDataDirectory = new DirectoryInfo(path);

            FileInfo[] txtFiles = myDataDirectory.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Matches: {0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine($"{file.Name}: {file.Length} bytes");
            }
        }
    }
}