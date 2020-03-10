using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Enclosure
    {
        //enum animals { Zebra, Penguin }
        public enum animalnames { Jeff, Tom, Joe, Karen, Chris, Steve, Stephen, Oliver, Emily, Bob }
        public int animalnum;
        public int size;
        public float temperature;
        public float humidity;
        public string environmentType;

        public List<Animal> storedAnimals;

        public Enclosure(string environmentType)
        {
            this.environmentType = environmentType;
            storedAnimals = new List<Animal>();
        }

        public void addAnimal(Animal animal)
        {
            storedAnimals.Add(animal);
        }

        public 
    }
    
}
