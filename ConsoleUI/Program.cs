using System;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string rootPath = @"E:\Temp\Demos\FileSystem";

            bool directoryExists = Directory.Exists(@"E:\Temp\Demos\FileSystem\SubFolder3");

            if (directoryExists)
            {
                Console.WriteLine("The directory exists");
            }
            else
            {
                Console.WriteLine("The directory doesn't exist");
            }
        }
    }
}