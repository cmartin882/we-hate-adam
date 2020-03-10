using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class zoo
    {
        public int feedingtime;
        public enclosure enclosure1;
        public zoo()
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
    public class enclosure
    {
        //enum animals { Zebra, Penguin }
       public enum animalnames { Jeff, Tom, Joe, Karen, Chris, Steve, Stephen, Oliver, Emily, Bob }
        public int animalnum;
        public int size;
        public float temperature;
        public float humidity;
        public string environmentType;

        public List<Animal> storedAnimals;

        public enclosure(string environmentType)
        {
            this.environmentType = environmentType;
            storedAnimals = new List<Animal>();
        }

        public void addAnimal(Animal animal)
        {

            storedAnimals.Add(animal);
           

           
        }

        public class Animal
        {
            public int weight;
            public int age { get; set; }
            public int hungry;
            public string idealenvironment;
            public string foodtype;
            public int breedingage;
            public bool gender;
            public int happiness;
            public Animal()
            {
                Random random = new Random();

                int weight = random.Next(0, 51);
                this.weight = weight;

                int age = random.Next(0, 25);
                this.age = age;

                bool gender = random.Next(0, 2) == 1 ? true : false;
                this.gender = gender;

                int hungry = random.Next(0, 10);
                this.hungry = hungry;

                int happiness = random.Next(0, 10);
                this.happiness = happiness;

            }
            public void mate()
            {
                if (age >= breedingage)
                {
                    Console.WriteLine("mate");
                    if (this.happiness == 9)
                    {
                    }
                    else this.happiness += 1;
                } 
                else
                {
                    Console.WriteLine("dont mate");
                }
            }
            public void eat()
            {
                if (hungry < 9)
                    Console.WriteLine("eat");
                else
                    Console.WriteLine("don't eat");
            }


        }
        public class Zebra : Animal
        {
            public Zebra()
            {
                this.idealenvironment = "grass";
                this.breedingage = 4;


            }
        }

        public class penguin : Animal
        {
            public penguin()
            {
                this.idealenvironment = "cold water";
                this.breedingage = 5;


            }

        }
    }
}
