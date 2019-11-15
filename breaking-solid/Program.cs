using System;

namespace breaking_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breaking SOLID!");
            PlayerManagement playerManager = new PlayerManagement();

            Player p1 = new Player(PlayerClass.Fighter, "Raegar", 14, 3, 7);
            Player p2 = new Player(PlayerClass.Wizard, "Althoif", 4, 16, 6);

            playerManager.AddPlayer(p1);
            playerManager.AddPlayer(p2);

            playerManager.DisplayPlayers();

            p2.CastDefensiveSpell();
            p1.Attack(p2);
            

            Console.WriteLine();
            playerManager.DisplayPlayers();
        }
    }
}
