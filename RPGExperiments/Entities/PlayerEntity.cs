using System;
using System.Collections.Generic;
using RPGExperiments.Equipment;
using RPGExperiments.Spells;
using RPGExperiments.Classes;

namespace RPGExperiments.Entities
{
    public static class TestPlayers
    {
        /* Player base stats should sum to between 65 and 69. */
        static byte levelBase = 50;                                                              /* STR VIT AGL INT SPR RES LCK CHR */
        public static PlayerEntity Kazuma = new PlayerEntity("Kazuma", (byte)(levelBase + 4),       6,  7,  13, 9,  4,  9,  14, 6,  CharacterClasses.Adventurer, TestWeapons.StellarShortsword, TestArmour.LightAdamantBoundOutfit, TestAccessories.StealSash);
        public static PlayerEntity Aqua = new PlayerEntity("Aqua", (byte)(levelBase + 4),           7,  8,  6,  4,  16, 13, 1,  14, CharacterClasses.WhiteMage, TestWeapons.StellarStaff, TestArmour.MediumStellarBoundOutfit, TestAccessories.GoddessRibbon);
        public static PlayerEntity Megumin = new PlayerEntity("Megumin", (byte)(levelBase + 5),     4,  3,  9,  14, 6,  10, 11, 11, CharacterClasses.BlackMage, TestWeapons.AdamantRod, TestArmour.LightCrystalWovenRobes, TestAccessories.CrimsonEyepatch);
        public static PlayerEntity Darkness = new PlayerEntity("Darkness", (byte)(levelBase + 5),   13, 14, 2,  5,  9,  11, 5,  8,  CharacterClasses.Paladin, TestWeapons.AdamantBroadsword, TestArmour.HeavyAdamantArmour, TestAccessories.PaladinBadge);

        public static PlayerEntity Wiz = new PlayerEntity("Wiz", (byte)(levelBase + 8),             10, 10, 5,  6,  12, 7,  9,  7,  CharacterClasses.Geomancer, TestWeapons.CrystalDagger, TestArmour.HeavyStellarWovenRobes, TestAccessories.LichBadge);
        public static PlayerEntity Yunyun = new PlayerEntity("Yunyun", (byte)(levelBase + 2),       9,  7,  6,  14, 8,  10, 5,  7,  CharacterClasses.BlackMage, TestWeapons.AdamantRod, TestArmour.MediumCrystalBoundOutfit, TestAccessories.CrimsonRibbon);
        public static PlayerEntity Chris = new PlayerEntity("Chris", (byte)(levelBase + 2),         6,  5,  14, 9,  6,  5,  16, 8,  CharacterClasses.Thief, TestWeapons.StellarDagger, TestArmour.LightAdamantBoundOutfit, TestAccessories.RuneAmulet);

        public static PlayerEntity Sam = new PlayerEntity("Sam", (byte)(levelBase + 1),             7,  6,  9,  12, 10, 11, 6,  7,  CharacterClasses.BlueMage, TestWeapons.CrystalRod, TestArmour.LightAdamantWovenRobes, TestAccessories.AzureCape);
        public static PlayerEntity Lewis = new PlayerEntity("Lewis", (byte)(levelBase + 1),         9,  7,  7,  10, 12, 10, 4,  9,  CharacterClasses.RedMage, TestWeapons.AdamantShortsword, TestArmour.LightCrystalArmour, TestAccessories.RedGem);
        public static PlayerEntity Freddie = new PlayerEntity("Freddie", (byte)(levelBase + 1),     11, 9,  8,  5,  6,  10, 12, 7,  CharacterClasses.Monk, TestWeapons.MonkFists, TestArmour.MonkGi, TestAccessories.BowTie);
        public static PlayerEntity James = new PlayerEntity("James", (byte)(levelBase + 1),         6,  8,  11, 7,  12, 9,  6,  9,  CharacterClasses.WhiteMage, TestWeapons.AdamantStaff, TestArmour.HeavyCrystalWovenRobes, TestAccessories.WhiteArmlet);

        public static PlayerEntity May = new PlayerEntity("May", (byte)(levelBase + 1),             6,  4,  12, 8,  5,  7,  16, 10, CharacterClasses.Thief, TestWeapons.AdamantDagger, TestArmour.LightCrystalBoundOutfit, TestAccessories.CrimsonRibbon); 

        public static List<BaseEntity> Entities = new List<BaseEntity> { Kazuma, Aqua, Megumin, Darkness, Wiz, Yunyun, Chris, Sam, Lewis, Freddie, James, May };
    }

    public class PlayerEntity : BaseEntity
    {
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

        public double TotalHealthMult { get => 1d + Weapon.Increase.HealthInc + Armour.Increase.HealthInc + Accessory.Increase.HealthInc; }
        public double TotalManaMult { get => 1d + Weapon.Increase.ManaInc + Armour.Increase.ManaInc + Accessory.Increase.ManaInc; }
        public ushort TotalPhysAtkInc { get => (ushort)(Weapon.Increase.PhysAtkInc + Armour.Increase.PhysAtkInc + Accessory.Increase.PhysAtkInc); }
        public ushort TotalPhysDefInc { get => (ushort)(Weapon.Increase.PhysDefInc + Armour.Increase.PhysDefInc + Accessory.Increase.PhysDefInc); }
        public ushort TotalBlackMagInc { get => (ushort)(Weapon.Increase.BlackMagInc + Armour.Increase.BlackMagInc + Accessory.Increase.BlackMagInc); }
        public ushort TotalWhiteMagInc { get => (ushort)(Weapon.Increase.WhiteMagInc + Armour.Increase.WhiteMagInc + Accessory.Increase.WhiteMagInc); }
        public ushort TotalMagDefInc { get => (ushort)(Weapon.Increase.MagDefInc + Armour.Increase.MagDefInc + Accessory.Increase.MagDefInc); }
        public ushort TotalHitRateInc { get => (ushort)(Weapon.Increase.HitRateInc + Armour.Increase.HitRateInc + Accessory.Increase.HitRateInc); }
        public ushort TotalSpeedInc { get => (ushort)(Weapon.Increase.SpeedInc + Armour.Increase.SpeedInc + Accessory.Increase.SpeedInc); }
        public ushort TotalCharmInc { get => (ushort)(Weapon.Increase.CharmInc + Armour.Increase.CharmInc + Accessory.Increase.CharmInc); }

        public override int MaxHealth { get => (int)Utils.Clamp(((12 + baseVit) * level * 7 + baseLck * Math.Log(level)) * TotalHealthMult, 1, 9999); }
        public override int MaxMana { get => (int)Utils.Clamp(((baseInt + baseSpt + baseRes / 2) * level / 1.5 + baseLck * Math.Log(level)) * TotalManaMult, 1, 999); }
        public override ushort PhysAtk { get => (ushort)Utils.Clamp(((baseStr + 12) * level / 2 + TotalPhysAtkInc) * PowerMultiplier, 1, 999); }
        public override ushort PhysDef { get => (ushort)Utils.Clamp(((baseVit + 12) * level / 2 + TotalPhysDefInc) * PhysDefMultiplier, 1, 999); }
        public override ushort BlackMag { get => (ushort)Utils.Clamp((4 + baseInt + (baseChr / 4)) * level / 1.5 + TotalBlackMagInc, 1, 999); }
        public override ushort WhiteMag { get => (ushort)Utils.Clamp((4 + baseSpt + (baseChr / 4)) * level / 1.5 + TotalWhiteMagInc, 1, 999); }
        public override ushort MagDef { get => (ushort)Utils.Clamp(((4 + baseRes + (baseInt + baseSpt) / 4) * level / 1.5 + TotalMagDefInc) * MagDefMultiplier, 1, 999); }
        public override ushort HitRate { get => (ushort)Utils.Clamp(((6 + baseAgl + (baseLck / 2)) * level / 1.5 + TotalHitRateInc) * HitMultiplier, 1, 999); }
        public override ushort Speed { get => (ushort)Utils.Clamp(((6 + baseAgl + (baseStr / 2)) * level / 1.5 + TotalSpeedInc) * SpeedMultiplier, 1, 999); }
        public override ushort Charm { get => (ushort)Utils.Clamp((6 + baseChr + (baseLck / 2)) * level / 1.5 + TotalCharmInc, 1, 999); }

        public Weapon Weapon { get; }
        public Armour Armour { get; }
        public Accessory Accessory { get; }

        public override double CritRate { get => (1 + baseLck / 16d) * Weapon.WType.Crit; }

        public byte BaseStatTotal { get => (byte)(baseStr + baseVit + baseAgl + baseInt + baseSpt + baseRes + baseLck + baseChr); }

        public double HitMultiplier { get => Weapon.WType.Hit; }
        public double PowerMultiplier { get => Weapon.WType.Pow; }
        public double PhysDefMultiplier { get => Armour.AType.PhysDef; }
        public double MagDefMultiplier { get => Armour.AType.MagDef; }
        public double SpeedMultiplier { get => Armour.AType.Mobility; }

        public BaseClass CharacterClass { get; }

        public PlayerEntity(string name_, byte level_, byte str_, byte vit_, byte agl_, byte int_, byte spt_, byte res_, byte lck_, byte chr_, BaseClass characterClass_, Weapon weapon_, Armour armour_, Accessory accessory_) : base(name_, level_)
        {
            baseStr = str_;
            baseVit = vit_;
            baseAgl = agl_;
            baseInt = int_;
            baseSpt = spt_;
            baseRes = res_;
            baseLck = lck_;
            baseChr = chr_;
            CharacterClass = characterClass_;
            Weapon = weapon_;
            Armour = armour_;
            Accessory = accessory_;
        }

        public override DamageInfo PhysicalAttackDamage(BaseEntity defender, Random r)
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

        public override ushort CastSpell(BaseSpell spell, BaseEntity target, Random r)
        {
            if (!spells.ContainsKey(spell))
                throw new Exception(name + " called CastSpell() with spell " + spell.Name + ", which is not in their spell list.");

            if (spell.GetType() == typeof(AttackSpell))
                return ((AttackSpell)spell).AttackDamage(this, target, r, (AttackSpell)spell, spells[spell], baseLck);
            if (spell.GetType() == typeof(HealSpell))
                return ((HealSpell)spell).HealAmount(this, target, r, (HealSpell)spell, spells[spell], baseLck);

            throw new Exception(name + " tried to cast a spell " + spell.Name + " with unknown type.");
        }
    }
}
