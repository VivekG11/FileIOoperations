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
            //  Program.ReadAllText();
            // Program.FileCopy();
            //Program.DelFile();
            // Program.ReadFromStreamReader();
            Program.WriteusingSTreamWriter();
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

        public static void FileCopy()
        {
            //using copy method to copy an existing file
            string copyPath = @"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\new.txt";
            File.Copy(filepath, copyPath);
        }
        public static void DelFile()
        {
            //using delete method to delete a particular file
            string path = @"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\new.txt";
            File.Delete(path);

        }
        public static void ReadFromStreamReader()
        {
            //using inbuilt stream reader class to read data from a file
            using(StreamReader reader = File.OpenText(filepath))
            {
                string s = "";
                while((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteusingSTreamWriter()
        {
            using(StreamWriter writer = File.AppendText(filepath))
            {
                writer.WriteLine(" TVS - Fellowship");
                writer.Close();

                Console.WriteLine(File.ReadAllText(filepath));

            }
        }
    }
}
