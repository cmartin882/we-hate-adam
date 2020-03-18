using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
        public bool cooldown;
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

            this.cooldown = false;

        }
        public void mate(string animaltype, Enclosure enclosuretype)
        {

            switch (animaltype)
            {
                case "zebra":
                    Zebra zebra = new Zebra { };
                    enclosuretype.addAnimal(zebra);
                    break;
                case "penguin":
                    Penguin penguin = new Penguin { };
                    enclosuretype.addAnimal(penguin);
                    break;

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

}




    
