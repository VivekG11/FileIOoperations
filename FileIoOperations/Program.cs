using System;
using System.IO;

namespace FileIoOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FileIOOperations.............");
            Program.FileExists();
        }

        public static void FileExists()
        {
            string filepath = @"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\details.txt";
            if(File.Exists(filepath))
            {
                Console.WriteLine("File exists..");
            }
            else
            {
                Console.WriteLine("No such file exists...");
            }
        }
    }
}
