using System;
using RPGExperiments.Spells;

namespace RPGExperiments.Entities
{
    public static class TestEnemies
    {
        public static EnemyEntity EvilThing = new EnemyEntity("Evil Thing", 40, 4000, 200, 500, 500, 500, 500, 500, 500, 500, 500, 1d/32d);
        public static EnemyEntity Erlant = new EnemyEntity("Erlant", 99, 200000, 1000, 999, 999, 999, 999, 999, 999, 999, 999, 1d/16d);
    }

    public class EnemyEntity : BaseEntity
    {
        protected int maxHealth;
        protected int maxMana;
        protected ushort physAtk;
        protected ushort physDef;
        protected ushort blackMag;
        protected ushort whiteMag;
        protected ushort magDef;
        protected ushort hitRate;
        protected ushort speed;
        protected ushort charm;

        public override int MaxHealth { get => maxHealth; }
        public override int MaxMana { get => maxMana; }
        public override ushort PhysAtk { get => physAtk; }
        public override ushort PhysDef { get => physDef; }
        public override ushort BlackMag { get => blackMag; }
        public override ushort WhiteMag { get => whiteMag; }
        public override ushort MagDef { get => magDef; }
        public override ushort HitRate { get => hitRate; }
        public override ushort Speed { get => speed; }
        public override ushort Charm { get => charm; }

        protected double critRate;

        public override double CritRate { get => critRate; }

        public EnemyEntity(string name_, byte level_, int maxHealth_, int maxMana_, ushort physAtk_, ushort physDef_, ushort blackMag_, ushort whiteMag_, ushort magDef_, ushort hitRate_, ushort speed_, ushort charm_, double critRate_) : base(name_, level_)
        {
            maxHealth = maxHealth_;
            maxMana = maxMana_;
            physAtk = physAtk_;
            physDef = physDef_;
            blackMag = blackMag_;
            whiteMag = whiteMag_;
            magDef = magDef_;
            hitRate = hitRate_;
            speed = speed_;
            charm = charm_;
            critRate = critRate_;
        }

        public override DamageInfo PhysicalAttackDamage(BaseEntity defender, Random r)
        {
            ushort damage = (ushort)Utils.Clamp(PhysAtk * 4 - defender.PhysDef + r.Next(1, (ushort)(3 + Math.Log(level) * 0)), 1, 9999);

            if (r.NextDouble() < CritRate)
            {
                /* Critical Hit */
                return new DamageInfo((ushort)(damage * 2), true, false);
            }
            if (r.Next(defender.Speed) > HitRate && r.Next(2) == 0)
            {
                /* Glancing Hit */
                return new DamageInfo((ushort)(damage / 2), false, true);
            }
            /* Normal Hit */
            return new DamageInfo(damage, false, false);
        }

        public override ushort CastSpell(BaseSpell spell, BaseEntity target, Random r)
        {
            if (!spells.ContainsKey(spell))
                throw new Exception(name + " called CastSpell() with spell " + spell.Name + ", which is not in their spell list.");

            //TODO: These luck values are statically 1 and may need changing.

            if (spell.GetType() == typeof(AttackSpell))
                return ((AttackSpell)spell).AttackDamage(this, target, r, (AttackSpell)spell, spells[spell], 1);
            if (spell.GetType() == typeof(HealSpell))
                return ((HealSpell)spell).HealAmount(this, target, r, (HealSpell)spell, spells[spell], 1);

            throw new Exception(name + " tried to cast a spell " + spell.Name + " with unknown type.");
        }
    }
}
