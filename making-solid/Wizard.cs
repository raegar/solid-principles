using System;

namespace making_solid
{
    public class Wizard : Player, ICastAttackSpells, ICastDefensiveSpells
    {

        public Wizard(string playerName, int might, int intellect, int speed) : base (PlayerClass.Wizard, playerName, might, intellect, speed)
        {

        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{PlayerName} is a magical Wizard");
            base.DisplayDetails();
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
    }
}