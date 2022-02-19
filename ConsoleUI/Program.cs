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

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], $"{destinationFolder}{i}.txt", true);
            }
        }
    }
}