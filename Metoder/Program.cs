using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro till Metoder/Funktioner, Main");

            SwapMethod();

            Console.WriteLine("Press enter to end program.");
        }


        static void SwapMethod()
        {
            int numA = 5, numB = 10;
            Console.WriteLine("Before swap: numA = {0} and numB = {1}", numA, numB);
            Swap(ref numA, ref numB);
            Console.WriteLine("After swap : numA = {0} and numB = {1}", numA, numB);
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp;
            Console.WriteLine("Inside swap: x = {0} and y = {1}", x, y);
            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
            Console.WriteLine("Inside swap: x = {0} and y = {1}", x, y);
        }
    }
}
