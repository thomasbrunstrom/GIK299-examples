using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro till arrayer, Main");

            //AccessArray();

            //InitArray();

            //Summa();

            //ArrayLenght();
            
            //ArrayOutOfBounds();

            //ArrayForEach();

            //ArrayForEachExample();

            //TwoDimensionalArray();

            //TwoDimensionalArrayByCode();
            
            Console.WriteLine("Press enter to end program.");
            Console.ReadLine(); // End of program, wait for user input before we close program.
        }

        static void AccessArray()
        {
            Console.WriteLine("AccessArray");
            int[] marks = new int[5] { 88, 90, 72, 40, 70 };
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("value in element {0} is {1}", i, marks[i]);
            }
        }
        static void InitArray()
        {
            Console.WriteLine("InitArray");
            const int size = 5;
            int[] marks = new int[size];
            int i;
            for (i = 0; i < size; i++)
            {
                marks[i] = readNumber("Enter next mark: ");
            }
            Console.WriteLine();
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("value in element {0} is {1}", i, marks[i]);
            }
        }
        private static int readNumber(string question)
        {
            Console.Write(question);
            string ans = Console.ReadLine();
            int number = int.Parse(ans);
            return number;
        }

        private static void Summa()
        {
            Console.WriteLine("Summa");
            const int size = 5;
            int[] marks = new int[size] { 88, 90, 72, 40, 70};
            int i;

            int sum = 0;
            for (i = 0; i < size;i++ )
                sum = sum + marks[i];
            Console.WriteLine("sum = {0}", sum);
        }

        private static void ArrayLenght() 
        {
            Console.WriteLine("Array length");
            int[] nummer = new int[] { 1, 5, 8, 20, -5, 22, 32, 55 };
            Console.WriteLine("Length of array: {0}", nummer.Length);
        }

        private static void ArrayOutOfBounds()
        {
            Console.WriteLine("Array out of bounds.");
            int[] nummer = new int[] { 1, 2, 3, 4, 5 };
            for(int i = 0; i < 6; i++) {
                Console.WriteLine("Array value: {0} at index: {1}", nummer[i], i);
            }
        }
        private static void ArrayForEach()
        {
            Console.WriteLine("Array ForEach.");
            int[] nummer = new int[] { 1, 2, 3, 4, 5 };
            foreach (int item in nummer)
            {
                Console.WriteLine("Current item: {0}", item);
            }
        }

        private static void ArrayForEachExample() {
            int sum = 0;
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            Console.WriteLine("Use foreach to display and sum the values");
            foreach (int x in nums)
            {
                Console.WriteLine("Value is: " + x);
                sum += x;
            }
            Console.WriteLine("Summation: " + sum);
        }

        private static void TwoDimensionalArray() 
        {
            int[,] a = {
                {0, 1, 2, 3}, 
                {4, 5, 6, 7},
                {8, 9, 10, 11},
                {12, 13, 14, 15}
            };
            for(int i = 0; i < a.GetLength(0); i++) {
                for(int j = 0; j < a.GetLength(1); j++) {
                    Console.WriteLine("Value at row: {0}, and column: {1} is: {2}", i, j, a[i, j]);
                }
            }
        }

        private static void TwoDimensionalArrayByCode() 
        {
            Random rand = new Random(); // Class to get random numbers. 
            int i, j, 
                rows = rand.Next(2, 8), 
                cols = rand.Next(2, 8);
            int[,] a = new int[rows, cols];

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    //Add a random number between 0 and 200.
                    a[i, j] = rand.Next(0, 1000);
                }
            }
            /* output each array element's value */
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }
    }
}
