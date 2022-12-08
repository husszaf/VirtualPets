using System;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.Menu();
            }
        }
    }
}