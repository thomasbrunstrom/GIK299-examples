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
            //Console.ReadLine();
        }


        static void SwapMethod()
        {
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
            Console.WriteLine("Inside swap: x = {0} and y = {1}", inx, iny);
            temp = inx; /* save the value of x */
            inx = iny;    /* put y into x */
            iny = temp; /* put temp into y */
            x = inx;
            y = iny;
            Console.WriteLine("Inside swap: x = {0} and y = {1}", x, y);
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
    }
}
