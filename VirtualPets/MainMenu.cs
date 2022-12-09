using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console; //Importing this library makes possible to write: WriteLine without Console.WriteLine
namespace VirtualPets
{
    class MainMenu //Main Menu class
    {
        public static bool Menu() //Menu method, here starts the first Menu
        {
            Title = "Pet Simulator"; //title of the program pop up window
            WriteLine($@"
 ██████╗ ███████╗████████╗    ███████╗██╗███╗   ███╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗ 
 ██╔══██╗██╔════╝╚══██╔══╝    ██╔════╝██║████╗ ████║██║   ██║██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
 ██████╔╝█████╗     ██║       ███████╗██║██╔████╔██║██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝
 ██╔═══╝ ██╔══╝     ██║       ╚════██║██║██║╚██╔╝██║██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗
 ██║     ███████╗   ██║       ███████║██║██║ ╚═╝ ██║╚██████╔╝███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║
 ╚═╝     ╚══════╝   ╚═╝       ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝
                                                                                                      ");  // ASCII text

            WriteLine("Choose an option below:"); //Options that shows on screen
            WriteLine("[Enter] Start game");
            WriteLine("[Esc] Quit");
            Write("\r\nSelect an option: ");

            var choice = ReadKey(); //Variable that stores the Keys typed by the player
            switch (choice.Key) //checks which key the player typed
            {
                case ConsoleKey.Enter: //If the player clicks Enter it will skip to the Start Method
                    Start(); //Starts the Start Method
                    return false; //Bool Method and Switch requires a return type
                case ConsoleKey.Escape: //If the player Clicks the Escape key
                    Exit();// It will run the Exit Method which terminates the program
                    return true;
                default: //If any other key than Enter and Escape is pressed
                    Clear(); //Clears the previous text on screen
                    WriteLine("Invalid command, wait and try again..."); //Displays the error
                    Menu();//Starts the Menu method
                    return false;
                    
            }

        }
        public static void Start() //Start Method
        {
           StartGame.Game();      //Starts the Game by sending the player to the StartGame Class Game method      
        }

        public static void Exit() //Method that allows to quit the program
        {
            //Kills the program
            Environment.Exit(1);
        }
    }
}
