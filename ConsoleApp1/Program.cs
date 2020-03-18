using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Enclosure;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //zebraEnclosure.environmentType

            Random random = new Random();
            int animalnamenum = random.Next(0, 10);
            int animalnum = random.Next(0, 2);

            Zoo.CreateThing(animalnamenum.GetType());
            string animalname = ((Enclosure.animalnames)animalnamenum).ToString();


            Enclosure grassEnclosure; //declaration of enclosures
            Enclosure coldwaterEnclosure;

            grassEnclosure = new Enclosure("grassEnclsoure"); //instantiation of enclosures
            coldwaterEnclosure = new Enclosure("coldwaterEnclosure");

            
            //searches for 1 female from a list which is suitable to mate



            Console.WriteLine();
            Console.ReadLine();

                        
            for (int i = 0; i < 10; i++)
            {
                for (int matesearch = 1; matesearch <= grassEnclosure.storedAnimals.Count; matesearch++)
                {
                    if ((grassEnclosure.storedAnimals[matesearch].age >= grassEnclosure.storedAnimals[matesearch].breedingage) && (grassEnclosure.storedAnimals[matesearch].gender = true) && (grassEnclosure.storedAnimals[matesearch].cooldown = false))
                    {
                        
                        Animal.mate(grassEnclosure.storedAnimals[matesearch].GetType().ToString(), grassEnclosure);
                    }
                }

                for (int matesearch = 1; matesearch <= coldwaterEnclosure.storedAnimals.Count; matesearch++)
                {
                    if ((coldwaterEnclosure.storedAnimals[matesearch].age >= coldwaterEnclosure.storedAnimals[matesearch].breedingage) && (coldwaterEnclosure.storedAnimals[matesearch].gender = true) && (coldwaterEnclosure.storedAnimals[matesearch].cooldown = false))
                    {

                        Animal.mate(coldwaterEnclosure.storedAnimals[matesearch].GetType().ToString(), coldwaterEnclosure);
                    }
                }
            }
        }
    }
}
