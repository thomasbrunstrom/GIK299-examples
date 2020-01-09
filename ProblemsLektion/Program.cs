using System;

namespace ProblemsLektion
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Problem1() == 29) {
                Console.WriteLine("Du lyckades med problem 1!");
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
            

            Console.ReadLine();
        }
        static int Problem1() {
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
            var talet = 559127;
            
            return talet;
        }

        static bool Problem2(int num) {
            //Ett primtal är bara delbart med sig själv och 1,
            //Några primtal är, 2, 5, 7, 19, 41
            return true;
        }
    }
}