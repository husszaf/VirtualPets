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
                if (Health == 0)
                {
                    Clear();
                    WriteLine("  ____   ____  ___ ___    ___       ___   __ __    ___  ____  \r\n /    T /    T|   T   T  /  _]     /   \\ |  T  |  /  _]|    \\ \r\nY   __jY  o  || _   _ | /  [_     Y     Y|  |  | /  [_ |  D  )\r\n|  T  ||     ||  \\_/  |Y    _]    |  O  ||  |  |Y    _]|    / \r\n|  l_ ||  _  ||   |   ||   [_     |     |l  :  !|   [_ |    \\ \r\n|     ||  |  ||   |   ||     T    l     ! \\   / |     T|  .  Y\r\nl___,_jl__j__jl___j___jl_____j     \\___/   \\_/  l_____jl__j\\_j\r\n                                                              ");
                    WriteLine("Game over! The pet health is 0. You lost the game.");
                    MainMenu.Exit();
                }
                else
                {
                    if (Hunger >= 10)
                    {
                        Health--;
                    }
                    
                }

                Clear();
                StartGame.Run();
            }
                        
        }

        
    }
    
}