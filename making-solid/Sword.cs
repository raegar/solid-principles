namespace making_solid
{
    public class Sword : IMeleeWeapon
    {
        public int Damage {get; set;}

        public Sword(int damage)
        {
            Damage = damage;
        }
    }
}