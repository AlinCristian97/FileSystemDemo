using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

            string textFilePath2 = @"E:\Temp\Demos\FileSystem\FileIO\testStream.txt";

            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randomString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randomString);
            
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            
            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];

            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte) fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            
            fs.Close();
            
            string textFilePath3 = @"E:\Temp\Demos\FileSystem\FileIO\textStreamWriterReader.txt";

            StreamWriter streamWriter = File.CreateText(textFilePath3);
            streamWriter.Write("This is a random ");
            streamWriter.WriteLine("sentence");
            streamWriter.WriteLine("This is another sentence");
            
            streamWriter.Close();
        }
    }
}