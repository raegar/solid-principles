namespace making_solid
{
    public interface ICastHealingSpells
    {
         void CastHealingSpell(Player target);
    }

    public interface ICastAttackSpells
    {
        void CastAttackSpell(Player target);
    }

    public interface ICastDefensiveSpells
    {
        void CastDefensiveSpell();
    }
}