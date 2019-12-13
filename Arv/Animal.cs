using System;

namespace Arv
{
    public enum Habitats { 
        Sea, 
        Land, 
        Air 
    }
    public abstract class Animal : IAnimal
    {
        protected string SpeciesName;
        protected DateTime BirthDay;
        protected Habitats Habitat;

        public void SetBirthDay(DateTime birthDay)
        {
            BirthDay = birthDay;
        }
        public void SetHabitat(Habitats habitat)
        {
            Habitat = habitat;
        }
        public string GetHabitatString()
        {
            string type = "unknown";
            switch(Habitat) {
                case Habitats.Sea:
                    type = "Sea";
                    break;
                case Habitats.Land:
                    type = "Land";
                    break;
                case Habitats.Air:
                    type = "Air";
                    break;
            }
            return type;
        }
    }
}