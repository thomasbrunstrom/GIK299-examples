using System;
using System.Numerics;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Intro till Metoder/Funktioner, Main");

            Console.WriteLine("Skriv namnet på person 1:");
            string namn = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 1:");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 2:");
            string namn2 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 2:");
            int age2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 3:");
            string namn3 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 3:");
            int age3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 4:");
            string namn4 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 4:");
            int age4 = Int32.Parse(Console.ReadLine());
            int totalAge = age + age2 + age3 + age4;
            double medelAge = totalAge / 4D;

            Console.WriteLine("{0} är {1} gammal.", namn, age);
            Console.WriteLine("{0} är {1} gammal.", namn2, age2);
            Console.WriteLine("{0} är {1} gammal.", namn3, age3);
            Console.WriteLine("{0} är {1} gammal.", namn4, age4);
            Console.WriteLine("Sammanlagd ålder är: {0}", totalAge);
            Console.WriteLine("Medelåldern är: {0:##.##}", medelAge);

            //SwapMethod();

            //GetQuota();

            //Summary();

            //Overloading();

            //Recurse(0);

            //StackOverFlowRecursion(0);

            //Factorial();
            
            Console.WriteLine("Press enter to end program.");
            Console.ReadLine();
        }

        static int ReadNumber(string prompt) 
        {
            Console.WriteLine(prompt);
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }

        static void GetQuota()
        {
            Console.WriteLine("GetQuota()");
            // 1. Declare the variables
            int numr, denom, quota, result, rest;

            // 2. Ask the user to enter the numerator and denominator.
            numr = ReadNumber("Enter a number for the Numerator:");
            denom = ReadNumber("Enter a number for the Denomiator:");
            
            // 3.1 Compute the quotas of the numerator and denominator
            quota = CalcQuota(numr, denom);
            // Print det result of CalcQuota.
            Console.WriteLine("{0} divided by {1} is {2}", numr, denom, quota);

            // 3.2 Compute the quotas of the numerator and denominator and return the result and the rest.
            bool noDividedByZero = CalcQuota(numr, denom, out result, out rest);
            if(noDividedByZero) {
                //Print the result if we didnt try to divide by zero.
                Console.WriteLine("{0} divided by {1} is {2} and the rest is {3}", numr, denom, result, rest);
            }
            else {
                //Let the user know we can't divide by zero (no computer can).
                Console.WriteLine("You tried to divide by zero, which is not allowed.");
            }
        }
        static int CalcQuota(int numr, int denom)
        {
            int q = numr / denom;
            return q;
        }
        static bool CalcQuota(int numr, int denom, out int result, out int rest)
        {
            result = 0;
            rest = 0;
            if(denom == 0) {
                return false;
            }
            result = numr / denom;
            rest = numr % denom;
            return true;
        }

        static void SwapMethod()
        {
            Console.WriteLine("SwapMethod()");
            int numA = 5, numB = 10, numAOut = 5, numBOut = 10;
            
            Console.WriteLine("Before Sawp: numA = {0} and numB = {1}", numA, numB);
            Swap(numA, numB);
            Console.WriteLine("After Swap: numA = {0} and numB = {1}", numA, numB);
            Console.WriteLine();
            
            Console.WriteLine("Before SwapWithOut: numA = {0}, numB = {1}, numAOut = {2} and numBOut = {3}", numA, numB, numAOut, numBOut);
            SwapWithOut(numA, numB, out numAOut, out numBOut);
            Console.WriteLine("After SwapWithOut: numA = {0}, numB = {1} numAOut = {2} and numBOut = {3}", numA, numB, numAOut, numBOut);
            Console.WriteLine();
            
            Console.WriteLine("Before SwapWithRef: numA = {0} and numB = {1}", numA, numB);
            SwapWithRef(ref numA, ref numB);
            Console.WriteLine("After SwapWithRef : numA = {0} and numB = {1}", numA, numB);
        }

        private static void Swap(int x, int y) {
            int temp;
            Console.WriteLine("Inside Swap: x = {0} and y = {1}", x, y);
            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
            Console.WriteLine("Inside swap: x = {0} and y = {1}", x, y);
        }

        private static void SwapWithOut(int inx, int iny, out int x, out int y) {
            int temp;
            Console.WriteLine("Inside SwapWitOut: x = {0} and y = {1}", inx, iny);
            temp = inx; /* save the value of x */
            inx = iny;    /* put y into x */
            iny = temp; /* put temp into y */
            x = inx;
            y = iny;
            Console.WriteLine("Inside SwapWitOut: x = {0} and y = {1}", x, y);
        }

        private static void SwapWithRef(ref int x, ref int y)
        {
            int temp;
            Console.WriteLine("Inside SwapWithRef: x = {0} and y = {1}", x, y);
            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
            Console.WriteLine("Inside SwapWithRef: x = {0} and y = {1}", x, y);
        }

        private static void Summary()
        {
            Console.WriteLine("Summary()");
            int val = 0;
            Summary1(val);
            Console.WriteLine(val); // Still 0!
            Summary2(ref val);
            Console.WriteLine(val); // Now 2!
            Summary3(out val);
            Console.WriteLine(val); // Now 3!
        }
        private static void Summary1(int value)
        {
            value = 1;
        }
        private static void Summary2(ref int value)
        {
            value = 2;
        }
        private static void Summary3(out int value)
        {
            value = 3;
        }

        private static void Overloading()
        {
            Console.WriteLine("Overloading()");
            Console.WriteLine("Addition of two integers::::::::::::::::{0}", Addition(2, 5));
            Console.WriteLine("Addition of two double type values::::::{0}", Addition(0.40f, 0.50f));
            Console.WriteLine("Addition of three integers::::::::::::::{0}", Addition(2, 5, 5));
            Console.WriteLine("Addition of three double type values::::{0}", Addition(0.40f, 0.50f, 0.60f));
        }
        private static int Addition(int a, int b)
        {
            return a + b;
        }
        private static int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        private static float Addition(float a, float b)
        {
            return a + b;
        }
        private static float Addition(float a, float b, float c)
        {
            return a + b + c;
        }

        static void Recurse(int counter) {
            counter++;
            if(counter < 10) {
                Recurse(counter);
            }
            Console.WriteLine("Counter are now: {0}", counter);
        }

        static void StackOverFlowRecursion(int counter)
        {
            counter++;
            Console.WriteLine("Counter is: {0}", counter);
            StackOverFlowRecursion(counter);
        }

        static void Factorial()
        {
            int number = ReadNumber("Write a number");
            Console.WriteLine("Factorial of {0} is: {1}", number, Factorial(number));
        }
        static int Factorial(int num) 
        {
            int result;
            if(num == 1) {
                return 1;
            }
            else {
                result = Factorial(num -1) * num;
                return result;
            }
        }
    }
}
