using System;

namespace making_solid
{
    public class Paladin : Player, IAttack, ICastAttackSpells, ICastHealingSpells, IEquipWeapon
    {
        IMeleeWeapon meleeWeapon = new Hammer(6);
        public Paladin(string playerName, int might, int intellect, int speed) : base (PlayerClass.Paladin, playerName, might, intellect, speed)
        {

        }

        public void EquipWeapon(IMeleeWeapon weapon)
        {
            this.meleeWeapon = weapon;
        }

        public void Attack(Player target)
        {
            Console.WriteLine($"{PlayerName} is attacking {target.PlayerName} for {meleeWeapon.Damage} damage");
            target.TakeDamage(meleeWeapon.Damage);
        }

        public void CastAttackSpell(Player target)
        {
            Console.WriteLine("Attaking with spell");
        }

        public void CastHealingSpell(Player target)
        {
            Console.WriteLine($"Healing {target.PlayerName} for {(Intellect/10)} HP");
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{PlayerName} is a tough Fighter");
            base.DisplayDetails();
        }
    }
}