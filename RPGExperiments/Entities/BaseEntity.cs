using System;
using System.Collections.Generic;
using RPGExperiments.Spells;

namespace RPGExperiments.Entities
{
    public struct DamageInfo
    {
        /* Critical and Glancing being true are mutually exclusive.
         * The state where they are both true is handled as critical but should never happen. */       

        public ushort Damage { get; }
        public bool Critical { get; }
        public bool Glancing { get; }

        public DamageInfo(ushort d, bool c, bool g)
        {
            Damage = d;
            Critical = c;
            Glancing = g;
        }
    }

    public abstract class BaseEntity
    {
        /* Level goes from 1 to 99, naturally. */
        protected byte level;
        public byte Level { get => level; }

        protected string name;
        public string Name { get => name; }

        protected Dictionary<BaseSpell, byte> spells;
        public Dictionary<BaseSpell, byte> Spells { get => spells; }

        public abstract int MaxHealth { get; }
        public abstract int MaxMana { get; }
        public abstract ushort PhysAtk { get; }
        public abstract ushort PhysDef { get; }
        public abstract ushort BlackMag { get; }
        public abstract ushort WhiteMag { get; }
        public abstract ushort MagDef { get; }
        public abstract ushort HitRate { get; }
        public abstract ushort Speed { get; }
        public abstract ushort Charm { get; }

        public abstract double CritRate { get; }

        protected BaseEntity(string name_, byte level_)
        {
            name = name_;
            level = level_;
            spells = new Dictionary<BaseSpell, byte>();
        }

        public abstract DamageInfo PhysicalAttackDamage(BaseEntity defender, Random r);

        public abstract ushort CastSpell(BaseSpell spell, BaseEntity target, Random r);

        public void AddSpell(BaseSpell spell, byte level)
        {
            spells.Add(spell, level);
        }

        public void AddSpells(ICollection<BaseSpell> spellsCollection, byte level)
        {
            foreach (BaseSpell spell in spellsCollection)
            {
                spells.Add(spell, level);
            }
        }
    }
}
