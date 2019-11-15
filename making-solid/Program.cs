using System;

namespace making_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making SOLID!");
            PlayerManagement playerManager = new PlayerManagement();

            Fighter player1 = new Fighter("Raegar", 14, 3, 7);
            Wizard player2 = new Wizard("Althoif", 4, 16, 6);

            playerManager.AddPlayer(player1);
            playerManager.AddPlayer(player2);

            playerManager.DisplayPlayers();

            player2.CastDefensiveSpell();
            player1.EquipWeapon(new Hammer(10));
            player1.Attack(player2);
            

            Console.WriteLine();
            playerManager.DisplayPlayers();
        }
    }
}
