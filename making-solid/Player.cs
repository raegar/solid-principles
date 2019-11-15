using System;

namespace making_solid
{
    public abstract class Player : ITakeDamage
    {
        protected readonly PlayerClass playerClass;
        public string PlayerName { get; }

        public int Armour { get; set; }
        public int Health { get; set; }

        public int Might { get; set; }
        public int Intellect { get; set; }
        public int Speed {get; set; }

        public Player(PlayerClass playerClass, string playerName, int might, int intellect, int speed)
        {
            this.playerClass = playerClass;
            PlayerName = playerName;
            Might = might;
            Intellect = intellect;
            Speed = speed;
            Armour = 1;
            Health = 20 + might;
        }

        public virtual void DisplayDetails()
        { 
            Console.WriteLine($"Might: {Might} | Intellect: {Intellect} | Speed: {Speed}");
            Console.WriteLine($"Armour: {Armour} | Health: {Health}");
            Console.WriteLine();
        }

        public void TakeDamage(int amount)
        {
            int damage = amount-Armour;
            Health -= damage;
            Console.WriteLine($"{PlayerName} has taken {damage} damage");
        }

    }
}