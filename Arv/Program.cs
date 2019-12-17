using System;
using System.IO;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"data.txt");
            Person[] persons = new Person[lines.Length];
            for(int i = 0; i < lines.Length; i++) {
                persons[i] = new Person();
                persons[i].Name = lines[i];
            }

            foreach(Person p in persons) {
                Console.WriteLine(p.Name);
            }

            string[] newLines = new string[5];
            for(int i = 0; i < 5; i++) {
                newLines[i] = Console.ReadLine();
            }

            string[] allLines= new string[newLines.Length + lines.Length];
            
            addLines(lines, ref allLines);
            addLines(newLines, ref allLines);

            File.WriteAllLines(@"data2.txt", allLines);

        }

        public static void addLines(string[] lines, ref string[] allLines) {
            for(int i = 0; i<lines.Length;i++) {
                allLines[i] = lines[i];
            }
        }
    }
}
