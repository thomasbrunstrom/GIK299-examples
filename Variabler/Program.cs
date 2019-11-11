using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intro till variabler, Main");
            
            //VariableTypes();
            
            //InitChar();

            //InitBool();

            //UseDecimal();

            //FindRadius();

            //DynamicInitilization();

            //ImplicitlyTypedVar();

            Console.WriteLine("Press enter to end program.");
            Console.ReadLine(); // End of program, wait for user input before we close program.
        }

        static void VariableTypes() 
        {
            Console.WriteLine("VariableTypes");
            sbyte a;
            byte b;
            short c;
            ushort d;
            int e;
            uint f;
            /* actual initialization */
            a = -128;
            b = 255;
            c = 32767;
            d = 65535;
            e = -2147483648;
            f = 4294967295;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }

        static void InitChar() 
        {
            Console.WriteLine("InitChar");
            char ch;
            ch = 'X';
            Console.WriteLine(ch);
        }

        static void InitBool() 
        {
            bool YesNo;
            YesNo = true;
            Console.WriteLine(YesNo);
        }

        static void UseDecimal()
        {
            Console.WriteLine("UseDecimal");
            decimal price;
            decimal discount;
            decimal discounted_price;
            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine(discounted_price);
        }

        static void FindRadius() 
        {
            Console.WriteLine("FindRadius");
            Double r;
            Double area;
            area = 10.0;
            //Math.PI is a constant, 3.1415926535897931
            r = Math.Sqrt(area / Math.PI);
            Console.WriteLine(r);
        }

        static void DynamicInitilization() {
            Console.WriteLine("DynamicInitilization");
            double s1 = 4.0; // Length of sides.
            double s2 = 5.0;
            // Dynamically initialize hypot.
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Hypotenuse of triangle with sides " + s1 + " by " + s2 + " is ");
            Console.WriteLine("{0:#.###}.", hypot);
        }

        static void ImplicitlyTypedVar() 
        {
            Console.WriteLine("ImplicitlyTypedVar");
            // These are now implicitly typed variables. They
            // are of type double because their initializing
            // expressions are of type double.
            var s1 = 4.0;
            var s2 = 5.0;
            // Now, hypot is implicitly typed. Its type is double
            // because the return type of Sqrt() is double.
            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Hypotenuse of triangle with sides " +
            s1 + " by " + s2 + " is ");
            Console.WriteLine("{0:#.###}.", hypot);
        }
    }
}
