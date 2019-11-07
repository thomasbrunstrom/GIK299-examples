using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro till Konsolen, Main");

            //ConsoleWrite();
            
            //ConsoleWriteLine();
            
            //OutputParameters();

            //FormatOutPut();

            //StandarFormatting();

            //ConsoleRead();

            //ConsoleReadLine();

            //ConsoleBeep();

            //ConsoleBeep();

            //ConsoleClear();
            
            Console.WriteLine("Press enter to end program.");
            //Console.ReadLine(); // End of program, wait for user input before we close program.
        }

        static void ConsoleWrite() 
        {
            Console.WriteLine("ConsoleRead");
            Console.Write("One "); // <-- This writes the word.      
            Console.Write("Two "); // <-- This is on the same line. 
            Console.Write("Three"); // <-- Also on the same line. 
        }

        static void ConsoleWriteLine() 
        {
            Console.WriteLine("ConsoleWriteLine");
            Console.WriteLine("Hello");
            Console.WriteLine(); // empty line
            Console.WriteLine("There");
        }

        static void OutputParameters()
        {
            Console.WriteLine("OutputParameters");
            string a = "Visual", b = "Studio", c = "Code";
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        static void FormatOutPut() 
        {
            Console.WriteLine("FormatOutPut");
            double x = 10.0;
            double y = 3.0;
            Console.WriteLine("{0} / {1} without formatting equals {2}", x, y, x / y);
            Console.WriteLine("{0} / {1} with formatting equals {2:#.##}", x, y, x / y);
        }

        static void StandarFormatting()
        {
            Console.WriteLine("StandardFormatting");
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency: . . . . . . . . {0:C}\n" +
                "(D) Decimal:. . . . . . . . . {0:D}\n" +
                "(E) Scientific: . . . . . . . {1:E}\n" +
                "(F) Fixed point:. . . . . . . {1:F}\n" +
                "(G) General:. . . . . . . . . {0:G}\n" +
                "(default):. . . . . . . . . . {0} (default = 'G')\n" +
                "(N) Number: . . . . . . . . . {0:N}\n" +
                "(P) Percent:. . . . . . . . . {1:P}\n" +
                "(R) Round-trip: . . . . . . . {1:R}\n" +
                "(X) Hexadecimal:. . . . . . . {0:X}\n",
                -123, -123.45f);
        }

        static void ConsoleRead()
        {
            Console.WriteLine("ConsoleRead");
            int x;
            Console.WriteLine("Enter a character");
            x = Console.Read();
            Console.WriteLine("Unformatted input as int: {0} ", x);
            char ch = (char) x; // get a char from x with conversion. int to char.
            Console.WriteLine("Key as char is: {0}", ch);
        }

        static void ConsoleReadLine()
        {
            string line;
            string age;
            Console.WriteLine("Enter your name:");
            line = Console.ReadLine();
            Console.WriteLine("Hello {0}", line);
            Console.WriteLine("Enter your age {0}:", line);
            age = Console.ReadLine(); // age is a string
            Console.WriteLine("{0} is {1} years old.", line, age);
        }

        static void ConsoleBeep()
        {
            string x; 
            Console.WriteLine("Enter any number"); 
            x = Console.ReadLine();
            Console.WriteLine("x = {0}", x); 
            Console.Beep(); 
        }
        
        static void ConsoleClear()
        {
            Console.WriteLine("Enter anything"); 
            String x = Console.ReadLine(); 
            Console.WriteLine("{0}", x); 
            Console.Clear(); //Tömmer fönstret
            Console.WriteLine("Try again"); 
            x = Console.ReadLine(); 
            Console.WriteLine("You typed: {0}", x); 
        }
    }
}
