using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;

namespace VirtualPets
{
    public class Pets //Pets class
    {
        public string Name { get; set; } //setting the variables/fields with getters and setters 
        public static int Hunger { get; set; }
        public static int Mood { get; set; }
        public static int Health { get; set; }
        public static int roomTemperature { get; set; }

        public static void DecreaseHunger() //Methid that makes the hunger, mood and health simulate
        {
            
            for (int moo = Mood; Mood <= 100 || Hunger <= 100; Mood--, Hunger++) //for loop that checks if mood, hunger is less or equal to 100 and then takes 1 from mood and gives 1 of hunger on each update
            {
                if (Health == 0) //if the health of the pet reaches 0
                {
                    Clear(); //clear the stats then below shows the game over ASCII text
                    WriteLine("  ____   ____  ___ ___    ___       ___   __ __    ___  ____  \r\n /    T /    T|   T   T  /  _]     /   \\ |  T  |  /  _]|    \\ \r\nY   __jY  o  || _   _ | /  [_     Y     Y|  |  | /  [_ |  D  )\r\n|  T  ||     ||  \\_/  |Y    _]    |  O  ||  |  |Y    _]|    / \r\n|  l_ ||  _  ||   |   ||   [_     |     |l  :  !|   [_ |    \\ \r\n|     ||  |  ||   |   ||     T    l     ! \\   / |     T|  .  Y\r\nl___,_jl__j__jl___j___jl_____j     \\___/   \\_/  l_____jl__j\\_j\r\n                                                              ");
                    WriteLine("Game over! The pet health is 0. You lost the game."); //displays Game over text
                    MainMenu.Exit();//Kills/ends the Program
                }
                else
                {
                    if (Hunger >= 10) //if hunger is greater or equal than 10
                    {
                        Health--; //takes 1 level of hunger
                    }
                    
                }

                Clear();//clears the previous stats
                StartGame.Run();//takes to the Run method of StartGame to keep the loop running
            }
                        
        }

        
    }
    
}