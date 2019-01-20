using System;
using System.Collections.Generic;

namespace RPGExperiments.Entities
{
    public abstract class BaseEntity
    {
        /* Level goes from 1 to 99, naturally. */
        protected byte level;
        public byte Level { get => level; }

        protected string name;
        public string Name { get => name; }

        protected Dictionary<Spell, byte> spells;
        public Dictionary<Spell, byte> Spells { get => spells; }

        /* Base stats vary from 1 to 16 for simplicity.
         * 1-2: Abysmal.
         * 3-4: Really bad.
         * 5-6: Weak points.
         * 7-8: Not great.
         * 9-10: Decent.
         * 11-12: Pretty good.
         * 13-14: Very talented.
         * 15-16: Godlike. */
        protected byte baseStr;
        protected byte baseVit;
        protected byte baseAgl;
        protected byte baseInt;
        protected byte baseSpt;
        protected byte baseRes;
        protected byte baseLck;
        protected byte baseChr;

        public abstract ushort MaxHealth { get; }
        public abstract ushort MaxMana { get; }
        public abstract ushort PhysAtk { get; }
        public abstract ushort PhysDef { get; }
        public abstract ushort BlackMag { get; }
        public abstract ushort WhiteMag { get; }
        public abstract ushort MagDef { get; }
        public abstract ushort HitRate { get; }
        public abstract ushort Speed { get; }
        public abstract ushort Charm { get; }

        public virtual ushort TotalHealthInc { get; }
        public virtual ushort TotalManaInc { get; }
        public virtual ushort TotalPhysAtkInc { get; }
        public virtual ushort TotalPhysDefInc { get; }
        public virtual ushort TotalBlackMagInc { get; }
        public virtual ushort TotalWhiteMagInc { get; }
        public virtual ushort TotalMagDefInc { get; }
        public virtual ushort TotalHitRateInc { get; }
        public virtual ushort TotalSpeedInc { get; }
        public virtual ushort TotalCharmInc { get; }

        public virtual double CritMultiplier { get => 1d/32d; }
        public virtual double HitMultiplier { get => 1.0d; }
        public virtual double PowerMultiplier { get => 1.0d; }

        public byte BaseStatTotal { get => (byte)(baseStr + baseVit + baseAgl + baseInt + baseSpt + baseRes + baseLck + baseChr); }

        protected BaseEntity()
        {

        }

        public ushort PhysicalAttackDamage(BaseEntity defender, Random r)
        {
            ushort damage = (ushort)Utils.Clamp(PhysAtk * 4 - defender.PhysDef + r.Next(1, (ushort)(3 + Math.Log(level) * baseLck)), 1, 9999);

            if (r.NextDouble() < CritMultiplier)
            {
                Console.WriteLine("Critical!");
                return (ushort)(damage * 2);
            }
            else if (r.Next(defender.Speed) > HitRate)
            {
                Console.WriteLine("Glancing...");
                return (ushort)(damage / 2);
            }
            else
                return damage;
        }

        public ushort SpellAttackDamage(BaseEntity defender, Random r, AttackSpell spell, byte level)
        {
            ushort mag;
            if (spell.Black)
                mag = BlackMag;
            else
                mag = WhiteMag;

            ushort rawDamage = (ushort)(mag * (spell.Power + (level / 8) * spell.Power) - defender.MagDef + r.Next(1, (ushort)(3 + Math.Log(this.level) * baseLck)));
            if (spell.BreakDamageLimit)
                return rawDamage;
            else
                return (ushort)Utils.Clamp(rawDamage, 1, 9999);
        }

        public ushort SpellHealAmount(BaseEntity patient, Random r, HealSpell spell, byte level)
        {
            ushort mag;
            if (spell.Black)
                mag = BlackMag;
            else
                mag = WhiteMag;

            ushort rawHeal = (ushort)(mag * (spell.Power + (level / 8) * spell.Power) + r.Next(1, (ushort)(3 + Math.Log(this.level) * baseLck)));

            return (ushort)Utils.Clamp(rawHeal, 1, 9999);
        }

        public void AddSpell(Spell spell, byte level)
        {
            spells.Add(spell, level);
        }

        public void AddSpells(ICollection<Spell> spellsCollection, byte level)
        {
            foreach (Spell spell in spellsCollection)
            {
                spells.Add(spell, level);
            }
        }
    }
}
