using System;

namespace Arv
{
    public class Fish : Animal, IAnimal
    {
        public Fish() 
        {
            
        }

        public void PrintSpeciesName()
        {
            Console.WriteLine(SpeciesName);
        }

        
    }
}