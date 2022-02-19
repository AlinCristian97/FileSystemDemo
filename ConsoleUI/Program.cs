using System;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            string[] directories = Directory.GetDirectories(rootPath);

            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
    }
}