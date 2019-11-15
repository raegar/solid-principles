using System;

namespace breaking_solid
{
    public class Player
    {
        private readonly PlayerClass playerClass;
        public string PlayerName { get; }

        private Sword sword = new Sword(5);

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

        public void DisplayDetails()
        {
            switch(playerClass)
            {
                case PlayerClass.Fighter:
                    Console.WriteLine($"{PlayerName} is a tough Fighter"); 
                    break;           
                case PlayerClass.Wizard:
                    Console.WriteLine($"{PlayerName} is a magical Wizard");
                    break; 
                case PlayerClass.Rogue:
                    Console.WriteLine($"{PlayerName} is a sneaky Rogue");
                    break; 
                default: Console.WriteLine($"{PlayerName} is not a recognized class");
                break; 
            } 
            Console.WriteLine($"Might: {Might} | Intellect: {Intellect} | Speed: {Speed}");
            Console.WriteLine($"Armour: {Armour} | Health: {Health}");
            Console.WriteLine();
        }

        public void Attack(Player target)
        {
            Console.WriteLine($"{PlayerName} is attacking {target.PlayerName} for {sword.Damage} damage");
            target.TakeDamage(sword.Damage);
        }

        public void CastAttackSpell(Player target)
        {
            int damage = (Intellect/10);
            Console.WriteLine($"{PlayerName} is attacking {target.PlayerName} for {damage} damage");
            target.TakeDamage(damage);
        }

        public void CastDefensiveSpell()
        {
            Console.WriteLine($"{PlayerName} is casting a defensive Spell");
            Armour += 1;
        }


        public void Sneak()
        {
            Console.WriteLine($"{PlayerName} is sneaking");
        }

        public void TakeDamage(int amount)
        {
            int damage = amount-Armour;
            Health -= damage;
            Console.WriteLine($"{PlayerName} has taken {damage} damage");
        }

    }
}