using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using VirtualPets;
using static System.Console;

namespace VirtualPets
{
    class MainMenu
    {
        public static bool Menu()
        {
            //Clear();
            WriteLine($@"
 ██████╗ ███████╗████████╗    ███████╗██╗███╗   ███╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗ 
 ██╔══██╗██╔════╝╚══██╔══╝    ██╔════╝██║████╗ ████║██║   ██║██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
 ██████╔╝█████╗     ██║       ███████╗██║██╔████╔██║██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝
 ██╔═══╝ ██╔══╝     ██║       ╚════██║██║██║╚██╔╝██║██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗
 ██║     ███████╗   ██║       ███████║██║██║ ╚═╝ ██║╚██████╔╝███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║
 ╚═╝     ╚══════╝   ╚═╝       ╚══════╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝
                                                                                                      ");

            WriteLine("Choose an option below:");
            WriteLine("[Enter] Start game");
            WriteLine("[Esc] Quit");
            Write("\r\nSelect an option: ");

            var choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.Enter:
                    Start();
                    return true;
                    break;
                case ConsoleKey.Escape:
                    Exit();
                    return true;
                default:
                    Clear();
                    Console.WriteLine("Invalid command, wait and try again...");
                    return false;
                    
            }

        }
        public static void Start()
        {
           StartGame.Game();            
        }

        public static void Exit() //Method that allows to quit the program
        {
            //Kills the program
            Environment.Exit(1);
        }
    }
}
