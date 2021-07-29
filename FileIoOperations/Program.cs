using System;
using System.IO;

namespace FileIoOperations
{
    class Program
    {
        static string filepath = @"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\details.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("FileIOOperations.............");
            //  Program.FileExists();
            // Program.ReadFile();
            Program.ReadAllText();
        }

        public static void FileExists()
        {
            //inserting file path
          //  string filepath = @"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\details.txt";
            if(File.Exists(filepath))
            {
                Console.WriteLine("File exists..");
            }
            else
            {
                Console.WriteLine("No such file exists...");
            }
        }
        public static void ReadFile()
        {
            //Reading data from file using string array
            string[] lines = File.ReadAllLines(filepath);
            foreach(var i in lines)
            {
                Console.WriteLine(i);
            }
        }

        public static void ReadAllText()
        {
            //using ReadAllText method to display data without for loop
            string data = File.ReadAllText(filepath);
            Console.WriteLine(data);
           
        }
    }
}
