using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testing
{
    public class Player
    {
        //Fields
        public string PlayerID { get; set; }
        public string Name { get; set; }
        public int SneakyLevel { get; set; }
        public String Difficulty { get; set; }
        public Boolean Alive { get; set; }

        


        public List<Player> AllPlayers = new List<Player>();
       
        //Empty constructor, so that method-calls can be made from main
        public Player()
        {
            
        }

        //Returns a certain player that has matching ID, same as the parameter
        public void FindPlayer(string PlayerKey)
        {
            var item = AllPlayers.FirstOrDefault(o => o.PlayerID.Equals(PlayerKey));

            if (item.PlayerID == PlayerKey)
            {
                Console.WriteLine("You chose " + PlayerKey + " " + item.Name);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Not found");
                Console.WriteLine("You chose an ID that doesnt exist. Choose from 1 to 4");
            }
        }
            
        //Adds new players to the list.
        public void ListPlayers()
        {
            AllPlayers.Add(new Player() { PlayerID = "1", Name = "Tom  ", SneakyLevel = 5, Difficulty = "Easy" , Alive = true });
            AllPlayers.Add(new Player() { PlayerID = "2", Name = "Tex  ", SneakyLevel = 10, Difficulty = "Hard" , Alive = true });

            //Prints out every player in the list.
            foreach (Player player in AllPlayers)
            {
                Console.WriteLine("PlayerID: " + player.PlayerID + " | Name: " + player.Name + " | Sneakiness: " 
                    + player.SneakyLevel + " | Difficulty: " + player.Difficulty + " | Alive: " + player.Alive  );
            }
        }
     }
}

    

