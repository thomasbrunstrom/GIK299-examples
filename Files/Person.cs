using System;

namespace Files {
    
    public struct HairInfo 
    {
        public string Color;
        public int Length;
    }

    [Serializable]
    public class Person
    {
        public string Name;
        public DateTime BirthDay; 
    }
}