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
        public static int[] Toys = new int[1]; // List that stores the balls that the user has purchased with default array size of '1'

        public Player() //Constructor of the Player class
        {
            int[] Coin = new int[1];
            int[] Toys = new int[1];
        }

        public static void FeedPet() //Feed method
        {
            if (Coin[0] >= 5) //checks if player has the minimum amount of coins to purchase the ball(1 ball = 5 Coins)
            {
                if (Pets.Hunger <= 99 && Pets.Hunger != 100) //checks if the pet's hunger level is not full
                {
                    Pets.Hunger -= Pets.Mood * Pets.Hunger; //the Hunger level will decreade depending on the Mood and the Hunger level of the Pet
                    if(Pets.Hunger <= 0) //If the Hunger level is 0 (checks if the pet is hungry)
                    {
                        Pets.Hunger = 0; //ensure that the pet level don't go below 0
                        WriteLine("  the Pet hunger is not low.\n");
                    }
                    else //if the hunger level is more than 0 it will decrease the hunger level
                    {
                        Coin[0] = Coin[0] - 5; //Takes 5 Coins out of the Player coins inventory
                        WriteLine("  The dog's mood has increased by 2\nThe cost of the bone is: 5 coins"); //Displays text
                    }
                    
                }

                else //if pet hunger is 100
                {
                    WriteLine("  the Pet hunger is not low.\n");
                }


            }

            else if (Coin[0] <= 5) //if Player does not have at least 5 coins
            {

                WriteLine($"  Insufficient funds! You have {Coin[0]} coins!\n"); //Displays the message
            }
        }

        public static void GiveBone() //Shop method to purchase different items
        {
            
            if (Coin[0] >= 5) //checks if player has the minimum amount of coins to purchase the ball(1 bone = 5 Coins)
            {
                if (Pets.Mood <= 99 && Pets.Mood != 100) //checks if the pet's Mood level is not full
                {
                    Pets.Mood += 5; //Adds 5 levels to pet's mood
                    Coin[0] = Coin[0] - 5; //Takes 5 coins from player inventory
                    WriteLine("  The dog's mood has increased by 2\nThe cost of the bone is: 5 coins");//Displays text
                }

                else //if pet's mood is 100
                {
                    WriteLine("  the Pet mood is not low. The pet is happy\n");
                }

            }

            else if (Coin[0] <= 5) //if Player does not have at least 5 coins
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
                    
                    Pets.Health += Pets.Health + 20; //add 20 levels to pet's health

                    if (Pets.Health >= 100) //if pets health is full
                    {
                        Pets.Health = 100; //ensures the pet health level don't go above 100
                        Coin[0] -= 5; //takes 5 coins
                        WriteLine("  the dog's health is increased by 20 points");
                        Pets.Hunger += Pets.Hunger + 10; //adds hunger 10 levels
                        WriteLine("  the dog was cured but his hunger increased by 10 points");
                    }
                    else //if hunger is less than 100 repeats the same as above
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

        public static void PlayWithBall() //play with the ball method
        {
            if (Toys[0] >= 1 ) //checks that there is at least 1 ball in toys inventory
            {
                
                WriteLine("  You threw the ball and the dog chased it."); //displays text
                Toys[0] -= 1; //takes one ball out of the toys inventory
                WriteLine($"  you have {Toys[0]} balls left"); //displays text
            }
            else if (Toys[0] < 1)//if toys inventory has 0 balls
            {
                WriteLine("  you have no ball left. buy the ball first to play with the dog"); //display text
            }
        }

        public static void PurchaseBall() //purchase the ball method
        {
            if (Coin[0] >= 5) //checks if the player has at least 5 coins
            {
                Coin[0] -= 5; //takes 5 coins out of the player coins inventory
                Toys[0] += 1; //adds 1 ball to the toys inventory
                WriteLine($"  1 ball added to your inventory. You now have {Toys[0]} balls.");
            }
            else //if coins are less than 5
            {
                WriteLine("  you don't have enough coins to purchase a ball\nYou need at least 5 coins to purchase a ball");
            }
        }

        public static void AdjustRoomTemperature() //adjusts the room tempeature by heating or cooling the room by checking the room temperature
        {
            if (Pets.roomTemperature >=20 && Pets.roomTemperature <= 29) //if the room temp. is beteen 20 to 29
            {
                WriteLine("Room is already at room temperature!"); //displays text
            }
            else {

                if (Pets.roomTemperature <= 20)// if is less than 20
                {
                    Pets.roomTemperature += 5; //adds 5 degrees the current temp.
                    WriteLine("The room temperature has been increased by 5 degrees"); //displays text
                }
                else if (Pets.roomTemperature >= 30)//if temp is greater than or equal 30
                {
                    Pets.roomTemperature -= 5; //removes 5 degrees from current temp
                    WriteLine("The room temperature has been decreased by 5 degrees");
                }
            }
            
        }

        public static void PlayerInput() // player input method to take the instructions from the player.

        {

            var quit = false; //Loop variable

            while (!quit)//checks the variable if the variable is true, keeps the menu running
            {
                
                var userInput = Console.ReadKey(); //captures the player input

                switch (userInput.Key) //takes the instruction from the player
                {
                    case ConsoleKey.D1: //feed pet
                    case ConsoleKey.NumPad1://use numbers from keypad and the keys above the text keys
                        FeedPet();
                        break;
                    case ConsoleKey.D2: //give to the dog the bone
                    case ConsoleKey.NumPad2:
                        GiveBone();
                        break;
                    case ConsoleKey.D3: //give medicine method starts
                    case ConsoleKey.NumPad3:
                        GiveMedicine();
                        break;
                    case ConsoleKey.D4: //pet dog method starts
                    case ConsoleKey.NumPad4:
                        WriteLine("you petted the dog");
                        break;
                    case ConsoleKey.D5: //play with the ball method starts
                    case ConsoleKey.NumPad5:
                        PlayWithBall();
                        break;
                    case ConsoleKey.D6: //purchase balls method starts
                    case ConsoleKey.NumPad6:
                        PurchaseBall();
                        break;
                    case ConsoleKey.D7: //keeps the room to room temperature 
                    case ConsoleKey.NumPad7:
                        AdjustRoomTemperature();// adjust temp method starts
                        break;
                    default:
                        Console.WriteLine("Key not recognised! use only the keys shown"); //if key is not from the above
                        break;
                }
                
            }

        }
        
    }
}
