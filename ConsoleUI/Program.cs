using System;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            string[] files = Directory.GetFiles(rootPath);
            string destinationFolder = @"E:\Temp\Demos\FileSystem\SubFolder1\";

            foreach (string file in files)
            {
                File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
            }
        }
    }
}