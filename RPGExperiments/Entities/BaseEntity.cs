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

        /* Base stats vary from 1 to 16 for simplicity.
         * 1-2: Abysmal.
         * 3-4: Really bad.
         * 5-6: Weak points.
         * 7-8: Not great.
         * 9-10: Decent.
         * 11-12: Pretty good.
         * 13-14: Very talented.
         * 15-16: Godlike. 
         */

        /* The base stats are as follows:
         * Strength (STR) - how strong you are, determines physical attack damage.
         * Vitality (VIT) - how tough and resistant to pain you are, affects health and physical defence.
         * Agility (AGL) - how fast or nimble you are, affects speed and hit rate.
         * Intelligence (INT) - how logical or clever you are, affects black magic and mana.
         * Spirit (SPR) - how compassionate and thoughtful you are, affects white magic and mana.
         * Resistance (RES) - how much willpower and conviction you have, affects magic defence and mana.
         * Luck (LCK) - how much fortune happens to favour you, affects hit rate and charm.
         * Charisma (CHR) - how friendly and personable you are to others, affects charm and magic.
         */
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

        public virtual double TotalHealthMult { get; }
        public virtual double TotalManaMult { get; }
        public virtual ushort TotalPhysAtkInc { get; }
        public virtual ushort TotalPhysDefInc { get; }
        public virtual ushort TotalBlackMagInc { get; }
        public virtual ushort TotalWhiteMagInc { get; }
        public virtual ushort TotalMagDefInc { get; }
        public virtual ushort TotalHitRateInc { get; }
        public virtual ushort TotalSpeedInc { get; }
        public virtual ushort TotalCharmInc { get; }

        public abstract double CritRate { get; }
        public abstract double HitMultiplier { get; }
        public abstract double PowerMultiplier { get; }
        public abstract double PhysDefMultiplier { get; }
        public abstract double MagDefMultiplier { get; }
        public abstract double SpeedMultiplier { get; }

        public byte BaseStatTotal { get => (byte)(baseStr + baseVit + baseAgl + baseInt + baseSpt + baseRes + baseLck + baseChr); }

        protected BaseEntity(string name_, byte level_)
        {
            name = name_;
            level = level_;
        }

        public DamageInfo PhysicalAttackDamage(BaseEntity defender, Random r)
        {
            ushort damage = (ushort)Utils.Clamp(PhysAtk * 4 - defender.PhysDef + r.Next(1, (ushort)(3 + Math.Log(level) * baseLck)), 1, 9999);

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

        public ushort CastSpell(BaseSpell spell, BaseEntity target, Random r)
        {
            if (!spells.ContainsKey(spell))
                throw new Exception(name + " called CastSpell() with spell " + spell.Name + ", which is not in their spell list.");

            if (spell.GetType() == typeof(AttackSpell))
                return ((AttackSpell)spell).AttackDamage(this, target, r, (AttackSpell)spell, spells[spell], baseLck);
            if (spell.GetType() == typeof(HealSpell))
                return ((HealSpell)spell).HealAmount(this, target, r, (HealSpell)spell, spells[spell], baseLck);

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
