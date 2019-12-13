using System;

namespace Arv
{
    public class Dog : Animal
    {
        public Dog(DateTime birthDay) 
            //Call emtpy constructor before we do anything inside here.
            : this() 
        {
            BirthDay = birthDay;
        }
        public Dog()
        {
            //Define habitat for dogs
            Habitat = Habitats.Land;
            //Define SpeciesName
            SpeciesName = "Canis lupus familiaris";
            //Define Birthday
            BirthDay = DateTime.Now;
        }

        public void PrintBirthday() {
            Console.WriteLine(BirthDay);
        }
        public void PrintSpeciesName()
        {
            Console.WriteLine(SpeciesName);
        }

        public void PrintHabitat()
        {
            string habitat = GetHabitatString();
            Console.WriteLine(habitat);
        }
    }
}