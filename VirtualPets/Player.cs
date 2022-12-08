using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;
namespace VirtualPets

{
    public class Player //Player class
    {
        public static int[] Coin = new int[1]; //List that stores the player coins on each update with default array size of '1'
        public static int[] Toys = new int[1];

        public Player() //Constructor of the Player class
        {
            int[] Coin = new int[1];
            int[] Toys = new int[1];
        }

        public static void FeedPet()
        {
            if (Coin[0] >= 5)
            {
                if (Pets.Hunger <= 99 && Pets.Hunger != 100)
                {
                    Pets.Hunger -= Pets.Mood * Pets.Hunger;
                    if(Pets.Hunger <= 0)
                    {
                        Pets.Hunger = 0;
                        WriteLine("  the Pet hunger is not low.\n");
                    }
                    else
                    {
                        Coin[0] = Coin[0] - 5;
                        WriteLine("  The dog's mood has increased by 2\nThe cost of the bone is: 5 coins");
                    }
                    
                }

                else
                {
                    WriteLine("  the Pet hunger is not low.\n");
                }


            }

            else if (Coin[0] <= 5)
            {

                WriteLine($"  Insufficient funds! You have {Coin[0]} coins!\n");
            }
        }

        public static void GiveBone() //Shop method to purchase different items
        {
            
            if (Coin[0] >= 5)
            {
                if (Pets.Mood <= 99 && Pets.Mood != 100)
                {
                    Pets.Mood += 5;
                    Coin[0] = Coin[0] - 5;
                    WriteLine("  The dog's mood has increased by 2\nThe cost of the bone is: 5 coins");
                }

                else
                {
                    WriteLine("  the Pet mood is not low. The pet is happy\n");
                }

            }

            else if (Coin[0] <= 5)
            {

                WriteLine($"  Insufficient funds! You have {Coin[0]} coins!\n");
            }

        }

        public static void GiveMedicine() //Shop method to purchase different items
        {
            if (Coin[0] >= 5) //If the user has at least 5 coins(1 health costs 12 coins and gives 20 points of health)
            {
                if (Pets.Health <= 99) //if the dog's health is 100 or below
                {
                    
                    Pets.Health += Pets.Health + 20;

                    if (Pets.Health >= 100)
                    {
                        Pets.Health = 100;
                        Coin[0] -= 5;
                        WriteLine("  the dog's health is increased by 20 points");
                        Pets.Hunger += Pets.Hunger + 10;
                        WriteLine("  the dog was cured but his hunger increased by 10 points");
                    }
                    else
                    {
                        Coin[0] = Coin[0] - 12;
                        WriteLine("  the dog's health is increased by 20 points");
                        Pets.Hunger += Pets.Hunger + 10;
                        WriteLine("  the dog was cured but his hunger increased by 10 points");
                    }

                    
                }
                else
                {
                    WriteLine("  The dog's health is already at its best\nyou can use the medicine only when the dog's health is 99 or less");
                }
            }
            else
            {
                WriteLine("  you don't have enough coins to increase health\nYou need at least 12 coins to increase the dog's health");
                
            }
        }

        public static void PlayWithBall()
        {
            if (Toys[0] >= 1 )
            {
                
                WriteLine("  You threw the ball and the dog chased it.");
                Toys[0] -= 1;
                WriteLine($"  you have {Toys[0]} balls left");
            }
            else if (Toys[0] < 1)
            {
                WriteLine("  you have no ball left. buy the ball first to play with the dog");
            }
        }

        public static void PurchaseBall()
        {
            if (Coin[0] >= 5)
            {
                Coin[0] -= 5;
                Toys[0] += 1;
                WriteLine($"  1 ball added to your inventory. You now have {Toys[0]} balls.");
            }
            else
            {
                WriteLine("  you don't have enough coins to purchase a ball\nYou need at least 5 coins to purchase a ball");
            }
        }

        public static void AdjustRoomTemperature()
        {
            if (Pets.roomTemperature >=20 && Pets.roomTemperature <= 29)
            {
                WriteLine("Room is already at room temperature!");
            }
            else {

                if (Pets.roomTemperature <= 20)
                {
                    Pets.roomTemperature += 5;
                    WriteLine("The room temperature has been increased by 5 degrees");
                }
                else if (Pets.roomTemperature >= 30)
                {
                    Pets.roomTemperature -= 5;
                    WriteLine("The room temperature has been decreased by 5 degrees");
                }
            }
            
        }

        public static void PlayerInput() // player input method to take the instructions from the player.

        {

            var quit = false;

            while (!quit)
            {
                
                var userInput = Console.ReadKey();

                switch (userInput.Key)
                {
                    case ConsoleKey.D1: //feed pet
                    case ConsoleKey.NumPad1:
                        FeedPet();
                        break;
                    case ConsoleKey.D2: //give to the dog the bone
                    case ConsoleKey.NumPad2:
                        GiveBone();
                        break;
                    case ConsoleKey.D3: //give medicine
                    case ConsoleKey.NumPad3:
                        GiveMedicine();
                        break;
                    case ConsoleKey.D4: //pet dog
                    case ConsoleKey.NumPad4:
                        WriteLine("you petted the dog");
                        break;
                    case ConsoleKey.D5: //play with the ball
                    case ConsoleKey.NumPad5:
                        PlayWithBall();
                        break;
                    case ConsoleKey.D6: //purchase balls
                    case ConsoleKey.NumPad6:
                        PurchaseBall();
                        break;
                    case ConsoleKey.D7: //keeps the room to room temperature
                    case ConsoleKey.NumPad7:
                        AdjustRoomTemperature();
                        break;
                    default:
                        Console.WriteLine("Key not recognised! use only the keys shown");
                        break;
                }
                
            }

        }
        
    }
}
