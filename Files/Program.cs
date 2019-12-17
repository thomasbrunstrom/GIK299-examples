using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
namespace Files
{
    class Program
    {
        static readonly string jsonPath = "personinfo.json";
        static void Main(string[] args)
        {

            Console.WriteLine("Files");
            WriteAllText();
            ReadAllText();

            WriteAllLines();
            ReadAllLines();

            WriteWithOpen();
            ReadWithOpen();

            SaveJson();
            ReadJson();

            Console.ReadLine();
        }

        static void ReadJson()
        {
            string data = File.ReadAllText(jsonPath);
            List<Person> personer = JsonConvert.DeserializeObject<List<Person>>(data);
            personer.ForEach(p => {
                Console.WriteLine("Personen med namn: {0} fyller år {1}", p.Name, p.BirthDay);
            });
            Console.WriteLine();
        }
        static void SaveJson()
        {
            List<Person> personer = new List<Person>() {
                new Person() { Name = "Thomas", BirthDay = new DateTime(1979, 12, 04) },
                new Person() { Name = "Johanna", BirthDay = new DateTime(1988, 04, 16 )}
            };
            
            string json = JsonConvert.SerializeObject(personer);
            Console.WriteLine("Saved json {1} to file: {0}", jsonPath, json);
            File.WriteAllText(jsonPath, json);
            Console.WriteLine();
        }

        static void ReadWithOpen()
        {
            string path = "UsingOpen.txt";
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)) 
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                while (fs.Read(b,0,b.Length) > 0) 
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }            
        }
        static void ReadAllLines() 
        {
            string path = "UsingWriteAllLines.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }

        static void ReadAllText()
        {
            string path = "UsingReadAllText.txt";
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        static void WriteWithOpen()
        {
            string path = "UsingOpen.txt";
            if(!File.Exists(path)) {
                File.Create(path);
            }
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite)) 
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                fs.Write(info, 0, info.Length);
            }     
        }
        static void WriteAllLines()
        {
            string path = "UsingWriteAllLines.txt";
            string[] lines = new string[3] {
                "First line",
                "Second line",
                "Third line"
            };
            File.WriteAllLines(path, lines);
        }

        static void WriteAllText()
        {
            string path = "UsingReadAllText.txt";
            string content = "First line\nSecond line\nThird line\nLast line";
            File.WriteAllText(path, content);
        }
    }
}
