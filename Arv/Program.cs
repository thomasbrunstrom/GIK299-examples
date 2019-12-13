using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            a.PrintBirthday();
            a.SetBirthDay(new DateTime(2001, 05, 20));
            a.PrintBirthday();

            Dog b = new Dog(new DateTime(2015, 01, 15));
            b.PrintBirthday();
            b.PrintSpeciesName();
            b.PrintHabitat();
        }
    }
}
