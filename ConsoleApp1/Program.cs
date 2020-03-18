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

            grassEnclosure = new Enclosure("grass"); //instantiation of enclosures
            coldwaterEnclosure = new Enclosure("cold water");

            
            //searches for 1 female from a list which is suitable to mate



            Console.WriteLine();
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                
            }
        }
    }
}
