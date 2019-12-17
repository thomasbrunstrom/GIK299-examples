using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void ReadWithOpen()
        {
            string path = "UsingOpen.txt";
            using (FileStream fs = File.Open(path, FileMode.Open)) 
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
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None)) 
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
