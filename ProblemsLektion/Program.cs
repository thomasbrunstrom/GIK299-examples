using System;
using System.Numerics;

namespace ProblemsLektion
{
    class Program
    {
        static readonly string FileName = "data.txt";
        static void Main(string[] args)
        {

            int[] tal = new int[] { 2323, 29283, 23311, 53443, 65345 };
            int[] summor = new int[] { 10, 24, 10, 19, 23 };
            bool fail = false;
            for(int i = 0;i < tal.Length; i++) {
                if((Problem1(tal[i]) != summor[i])) {
                    fail = true;
                    break;
                }
            }
            if(fail) {
                Console.WriteLine("Du har löst uppgift 1 fel");
            }
            else {
                Console.WriteLine("Du har löst uppgift 1 rätt");
            }


            int[] isPrimeNumbers = new int[] { 29, 12, 55, 2, 7, 5, 91, 661, 673, 1091, 28, 33 };
            foreach(int num in isPrimeNumbers) {
                var result = Problem2(num);
                if(result) {
                    Console.WriteLine("{0} är ett primtal", num);
                }
                else {
                    Console.WriteLine("{0} är INTE ett primtal", num);
                }
            }

            
            if(Problem3() == 2211) {
                Console.WriteLine("Du lyckades med problem 3");
            }
            else {
                Console.WriteLine("Du har inte löst problem 3");
            }
            Console.ReadLine();
        }

        static int Problem1(int talet) 
        {
            //För att dela upp en sträng kan man använda sig av string.ToCharArray()
            //En char innehåller asciikoden för varje tecken
            //T = 84 i ascii
            //h = 104
            //o = 111
            //m = 109
            //a = 97
            //s = 115
            //7 = 55
            //9 = 57
            return 0;
        }

        static bool Problem2(int num) 
        {
            //Ett primtal är bara delbart med sig själv och 1,
            //Några primtal är, 2, 5, 7, 19, 41
            return true;            
        }

        static int Problem3() 
        {
            //Läs in datat som ligger i data.txt,
            //Summera de 500 första decimalerna och returnera svaret
            return 0;
        }
    }
}