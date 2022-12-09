using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;
namespace VirtualPets
{
    public class StartGame //Starts the Game
    {
        public static Dog dog; //Instance of Dog class

        public static void Game()
        {
            string petName = "Dog";//ReadLine();
            dog = new Dog(petName); //Creating the Dog instance
            Player player = new Player(); //Creating the Player Instance

            Thread moodthread = new Thread(Pets.DecreaseHunger);//Mood Thread
            Thread playerthread = new Thread(Player.PlayerInput);//Player Thread
            Thread foodthread = new Thread(Player.FeedPet);//Food Thread
            Thread bonethread = new Thread(Player.GiveBone);// Give Bone Thread
            Thread roomTemperaturethread = new Thread(RoomTemperature); //Room Thread
            moodthread.Start(); //Starts all the threads
            playerthread.Start();
            foodthread.Start();
            roomTemperaturethread.Start();
        }

        public static void Run() //Starts the Program that displays stats
        {
            //ASCII text to show the Dog ASCII Text/Image
            WriteLine(@"
           _ 
      /\,_/\| 
      /==_ ( 
     (Y_.) /       /// 
      U ) (__,_____) ) 
        )'   >     `/ 
        |._  _____  | 
        | | (    \| ( 
        | | |    || | 
   ,,-. ),)_/ ., ))_/,,.-,_ 
");
            //Displays stats
            WriteLine($"Pet Name: {dog.Name}\nHunger level: {Pets.Hunger}\nMood level: {Pets.Mood}\nHealth level: {Pets.Health} \nPlayer has {Player.Coin[0]} coins\nRoom temperature: {Pets.roomTemperature}\nBalls left: {Player.Toys[0]}\n\n");
            Player.Coin[0]++;//Adds one coin on each update by 1 Coin
            WriteLine("To interact with the Dog choose an option below:"); //Shows instruction on how to interact with the pet
            WriteLine("[1] Feed Dog -> Cost: 5 Coins");
            WriteLine("[2] Give bone -> Cost: 5 Coins");
            WriteLine("[3] Give medicine -> Cost: 5 Coins");
            WriteLine("[4] Tend to Pet");
            WriteLine("[5] Play with the ball");
            WriteLine("[6] Purchase the ball -> Cost: 1 Coins");
            WriteLine($"[7] Adjust room temperature\n");
            WriteLine("\n\t\t\t\t\tThe statistics update time is 5 seconds");
            Thread.Sleep(5000); //Waits 5 seconds before updating
        }

        public static void RoomTemperature() //Room Temperature method that changes the temperature
        {
            for (int i = 100; i == 100;) //Starts the loop to keep the temperature changing
            {
                Pets.roomTemperature--; //Decreases temperature on each update by 1 degree
                
                if (Pets.roomTemperature >= 30) //If the room temperature is greater than 30
                {
                    WriteLine("Room is too hot!"); //Displays text
                    Pets.Health--; //Decreases health by 1
                }
                else if(Pets.roomTemperature <= 15) //if room temperature is less than 15
                {
                    Console.WriteLine("Room is too cold!");
                    Pets.Health--; //Decreases by one
                }
                Thread.Sleep(15000); //waits 15 seconds before decreasing temperature

            }
        }

    }
}