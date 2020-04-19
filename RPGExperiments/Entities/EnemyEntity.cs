using System;
using RPGExperiments.Spells;

namespace RPGExperiments.Entities
{
    public static class TestEnemies
    {
        public static EnemyEntity Erlant = new EnemyEntity("Erlant", 99, 200000, 1000, 750, 800, 999, 999, 999, 700, 700, 650, 1d/16d);
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
    }
}
