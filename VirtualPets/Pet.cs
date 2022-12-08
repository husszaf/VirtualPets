using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;

namespace VirtualPets
{
    public class Pets
    {
        public string Name { get; set; }
        public static int Hunger { get; set; }
        public static int Mood { get; set; }
        public static int Health { get; set; }
        public static int roomTemperature { get; set; }

        public static void DecreaseHunger()
        {
            for (int moo = Mood; Mood <= 100 || Hunger <= 100; Mood--, Hunger++)
            {
                if (Hunger >= 50)
                {
                    Health--;
                    WriteLine("the dog's health is going down, give him medicine to increase health");
                }
                Clear();
                StartGame.Run();
            }
        }

        
    }
    
}