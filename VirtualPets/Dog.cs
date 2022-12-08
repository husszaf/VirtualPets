using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;
namespace VirtualPets
{
    public class Dog : Pets //Inherits from the Pet class
    {

        public Dog(string name) //Constructor
        {
            Random randomTemp = new Random();
            this.Name = name;
            Hunger = 0; //Initial values of dog when the program starts
            Mood = 100;
            Health = 100;
            roomTemperature = randomTemp.Next(0, 40);

        }

        
    }
}