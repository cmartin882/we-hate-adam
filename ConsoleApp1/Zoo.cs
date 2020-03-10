using System;

namespace ConsoleApp1
{
    public class Zoo
    {
        public int feedingtime;
        public Enclosure enclosure1;
        public Zoo()
        {
        }
        public void MakeEnclosure()
        {

        }

        static public void CreateThing(Type type)
        {
            var thing = Activator.CreateInstance(type);
        }

    }

}
    
