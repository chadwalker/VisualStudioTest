using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialTest
{
    [Serializable]
    class Person
    {
        public int age { get; set; }
        public string name {get; set;}

        public void Initialize()
        {
            age = 1;
            name = "John";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
  
            /*
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("c:\\MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();
            */

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person obj = (Person)formatter.Deserialize(stream);
            stream.Close();

            // Here's the proof.
            Console.WriteLine("n1: {0}", obj.age);
            Console.WriteLine("n2: {0}", obj.name);
            Console.ReadLine();
            




        }
    }
}
