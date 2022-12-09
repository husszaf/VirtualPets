using System;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true; //Loop that makes the console running
            while (showMenu) //Loop starts here
            {
                showMenu = MainMenu.Menu(); //while in loop, it will show the Menu (Method) in MainMenu class
            }
        }
    }
}