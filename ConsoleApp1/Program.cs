﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.enclosure;

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

            zoo.CreateThing(animalnamenum.GetType());
            string animalname = ((enclosure.animalnames)animalnamenum).ToString();


            enclosure animalEnclosure; //declaration of enclosure

            
            switch (animalnum)
            {
                case 0:
                    animalEnclosure = new enclosure("grass"); //instantiation of enclosure
                    Zebra zebra();
                       zebra(0) = new Zebra { };
                    animalEnclosure.addAnimal(zebra(0));
                    int iamanumber = zebra(0).age;
                    break;
                case 1:
                    animalEnclosure = new enclosure("cold water");
                    penguin penguin = new penguin { };
                    animalEnclosure.addAnimal(penguin);
                    break;
                    
            }
            
            //searches for 1 female 1 male from a certain species in list

            Console.WriteLine();
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                zebra(i).age
            }
        }
    }
}
