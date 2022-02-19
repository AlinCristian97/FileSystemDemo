using System;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}