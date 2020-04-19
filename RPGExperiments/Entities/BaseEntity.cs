using System;
using System.Collections.Generic;
using RPGExperiments.Spells;

namespace RPGExperiments.Entities
{
    public struct DamageInfo
    {  
        public ushort Damage { get; }
        public bool Critical { get; }

        public DamageInfo(ushort d, bool c)
        {
            Damage = d;
            Critical = c;
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

        public DamageInfo PhysicalAttackDamage(BaseEntity defender, Random r)
        {
            ushort damage = (ushort)(PhysAtk * 20 * (1500d - defender.PhysDef) / 1500d + r.Next(1, (ushort)(10 + level * 10)));
            bool crit = false;

            if (r.NextDouble() < CritRate)
            {
                /* Critical Hit */
                damage *= 2;
                crit = true;
            }

            return new DamageInfo((ushort)Utils.Clamp(damage, 1, 9999), crit);
        }

        public ushort CastSpell(BaseSpell spell, BaseEntity target, Random r)
        {
            if (!spells.ContainsKey(spell))
                throw new Exception(name + " called CastSpell() with spell " + spell.Name + ", which is not in their spell list.");

            if (spell.GetType() == typeof(AttackSpell))
                return ((AttackSpell)spell).AttackDamage(this, target, r, (AttackSpell)spell, spells[spell], level);
            if (spell.GetType() == typeof(HealSpell))
                return ((HealSpell)spell).HealAmount(this, target, r, (HealSpell)spell, spells[spell], level);

            throw new Exception(name + " tried to cast a spell " + spell.Name + " with unknown type.");
        }

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
