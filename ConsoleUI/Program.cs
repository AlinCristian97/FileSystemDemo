using System;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            string newPath = @"E:\Temp\Demos\FileSystem\SubFolder3\SubSubFolder4";
            
            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("The directory exists");
            }
            else
            {
                Console.WriteLine("The directory doesn't exist");
                Directory.CreateDirectory(newPath);
            }
        }
    }
}