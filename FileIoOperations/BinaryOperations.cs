using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIoOperations
{
    [Serializable]
    public class Demo
    {
       public string name { get; set; }
       public int id { get; set; }

        public Demo(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

    }
    public class BinaryOperations
    {
       public static void Serialization()
        {
            Demo demo = new Demo("Vivek", 13);
            FileStream fileStream = new FileStream(@"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\binary.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, demo);
        }
        public static void DeSerialization()
        {
            FileStream file = new FileStream(@"C:\Users\VIVEK\source\repos\FileIoOperations\FileIoOperations\binary.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo demoo = (Demo)binaryFormatter.Deserialize(file);
            Console.WriteLine("Name :"+demoo.name+"and id is :"+demoo.id);
        }

    }
}
