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

        public string GetNameAndClass()
        {
            switch(playerClass)
            {
                case PlayerClass.Fighter:
                    return $"{PlayerName} is a tough Fighter";
            
                case PlayerClass.Wizard:
                    return $"{PlayerName} is a magical Wizard";

                case PlayerClass.Rogue:
                    return $"{PlayerName} is a sneaky Rogue";

                default: return $"{PlayerName} is not a recgnosed class";
            } 
        }

        public void Attack(Player target)
        {
            target.TakeDamage(sword.Damage);
            Console.WriteLine($"Attacking {target.PlayerName} for {sword.Damage} damage");
        }

        public void CastSpell()
        {
            Console.WriteLine("Casting Spell");
        }

        public void Sneak()
        {
            Console.WriteLine("I'm snaeking");
        }

        public void TakeDamage(int amount)
        {
            int damage = amount-Armour;
            Health -= damage;
            Console.WriteLine($"Taken {damage} damage");
        }

    }
}