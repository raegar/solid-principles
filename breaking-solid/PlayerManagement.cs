using System;
using System.Collections.Generic;

namespace breaking_solid
{
    public class PlayerManagement
    {
        public List<Player> Players = new List<Player>();

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void DisplayPlayers()
        {
            foreach(Player player in Players)
            {
                player.DisplayDetails();
            }
            Console.WriteLine();
        }

    }
}