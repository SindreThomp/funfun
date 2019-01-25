using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testing
{
    class Arena
    {
        
        Player AddPlayers = new Player();
        Weapon AddWeapons = new Weapon();
        ReadTextFile ReadThis = new ReadTextFile();

        public string PlayKey;
        public string WepKey;

        public Arena()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ReadThis.ReadFile(); //Read the first textfile
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            MakeList(); //Initializes the method
        }
        
        public void MakeList()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            //Initialize the player-list and weapons-list
            AddPlayers.ListPlayers();
            Console.WriteLine();
            Console.WriteLine();
            AddWeapons.AddWeapons();
            //Make your decision
            ChoosePlayerAndWeapon();
      
        }

        //Choose your player - ReadLine
        public void ChoosePlayerAndWeapon()
        {
            Console.WriteLine();
            Console.WriteLine("Choose player:");
            PlayKey = Console.ReadLine();    

            AddPlayers.FindPlayer(PlayKey);

            Console.WriteLine();
            Console.WriteLine("Choose your weapon");
            WepKey = Console.ReadLine();
            AddWeapons.FindWeapon(WepKey);

        }



    }
}



