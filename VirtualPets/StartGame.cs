using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;
namespace VirtualPets
{
    public class StartGame
    {
        public static Dog dog;

        public static void Game()
        {
            string petName = "Dog";//ReadLine();
            dog = new Dog(petName);
            Player player = new Player();

            //Thread moodthread = new Thread(new ThreadStart(Pets.decreaseHunger));
            //Thread playerthread = new Thread(new ThreadStart(UserPlayer));

            Thread moodthread = new Thread(Pets.DecreaseHunger);
            Thread playerthread = new Thread(Player.PlayerInput);
            Thread foodthread = new Thread(Player.FeedPet);
            Thread bonethread = new Thread(Player.GiveBone);
            Thread roomTemperaturethread = new Thread(RoomTemperature);
            moodthread.Start();
            playerthread.Start();
            foodthread.Start();
            roomTemperaturethread.Start();
        }

        public static void Run()
        {
            //Clear();
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
            WriteLine($"Pet Name: {dog.Name}\nHunger level: {Pets.Hunger}\nMood level: {Pets.Mood}\nHealth level: {Pets.Health} \nPlayer has {Player.Coin[0]} coins\nRoom temperature: {Pets.roomTemperature}\nBalls left: {Player.Toys[0]}\n\n");
            Player.Coin[0]++;
            WriteLine("To interact with the Dog choose an option below:");
            WriteLine("[1] Feed Dog -> Cost: 5 Coins");
            WriteLine("[2] Give bone -> Cost: 5 Coins");
            WriteLine("[3] Give medicine -> Cost: 5 Coins");
            WriteLine("[4] Tend to Pet");
            WriteLine("[5] Play with the ball");
            WriteLine("[6] Purchase the ball -> Cost: 1 Coins");
            WriteLine($"[7] Adjust room temperature\n");
            WriteLine("\n\t\t\t\t\tThe statistics update time is 5 seconds");
            Thread.Sleep(5000);
        }

        public static void RoomTemperature()
        {
            for (int i = 100; i == 100;)
            {
                Pets.roomTemperature--;
                
                if (Pets.roomTemperature >= 30)
                {
                    WriteLine("Room is too hot!");
                    Pets.Health--;
                }
                else if(Pets.roomTemperature <= 15)
                {
                    Console.WriteLine("Room is too cold!");
                    Pets.Health--;
                }
                Thread.Sleep(15000);

            }
        }

    }
}