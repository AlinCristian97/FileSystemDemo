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

            Directory.Delete(@"C:\Users\Alin-PC\C#DataTemp");
        }
    }
}