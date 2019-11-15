namespace making_solid
{
    internal class Hammer : IMeleeWeapon
    {
        public int Damage { get; set; }

        public Hammer(int damage)
        {
            Damage = damage;
        }
    }
}