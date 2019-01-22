using System;
using System.Collections.Generic;
using RPGExperiments.Equipment;
using RPGExperiments.Spells;
using RPGExperiments.Classes;

namespace RPGExperiments.Entities
{
    public static class TestEntities
    {
        /* Player base stats should sum to between 65 and 69. */
        static byte levelBase = 50;                                                              /* STR VIT AGL INT SPR RES LCK CHR */
        public static PlayerEntity Kazuma = new PlayerEntity("Kazuma", (byte)(levelBase + 4),       6,  7,  13, 9,  4,  9,  14, 6,  CharacterClasses.Adventurer, TestWeapons.MythrilShortsword, TestArmour.ThiefCape, TestAccessories.StealSash);
        public static PlayerEntity Aqua = new PlayerEntity("Aqua", (byte)(levelBase + 4),           7,  8,  6,  4,  16, 13, 1,  14, CharacterClasses.WhiteMage, TestWeapons.StaffOfRoses, TestArmour.GoddessSuit, TestAccessories.GoddessRibbon);
        public static PlayerEntity Megumin = new PlayerEntity("Megumin", (byte)(levelBase + 5),     4,  3,  9,  14, 6,  10, 11, 11, CharacterClasses.BlackMage, TestWeapons.CrimsonWoodRod, TestArmour.CrimsonHat, TestAccessories.CrimsonEyepatch);
        public static PlayerEntity Darkness = new PlayerEntity("Darkness", (byte)(levelBase + 5),   13, 14, 2,  5,  9,  11, 5,  8,  CharacterClasses.Paladin, TestWeapons.SteelBroadsword, TestArmour.CrusaderHeavy, TestAccessories.PaladinBadge);

        public static PlayerEntity Wiz = new PlayerEntity("Wiz", (byte)(levelBase + 8),             10, 10, 5,  6,  12, 7,  9,  7,  CharacterClasses.Adventurer, TestWeapons.CrystalDagger, TestArmour.PurpleRobes, TestAccessories.LichBadge);
        public static PlayerEntity Yunyun = new PlayerEntity("Yunyun", (byte)(levelBase + 2),       9,  7,  6,  14, 8,  10, 5,  7,  CharacterClasses.BlackMage, TestWeapons.CrimsonWand, TestArmour.CrimsonUniform, TestAccessories.CrimsonRibbon);
        public static PlayerEntity Chris = new PlayerEntity("Chris", (byte)(levelBase + 2),         6,  5,  14, 9,  6,  5,  16, 8,  CharacterClasses.Thief, TestWeapons.KnifeOfSilence, TestArmour.ThiefSuit, TestAccessories.RuneAmulet);

        public static PlayerEntity Sam = new PlayerEntity("Sam", (byte)(levelBase + 1),             7,  6,  9,  12, 10, 11, 6,  7,  CharacterClasses.BlueMage, TestWeapons.AzureStaff, TestArmour.AzureCloak, TestAccessories.AzureCape);
        public static PlayerEntity Lewis = new PlayerEntity("Lewis", (byte)(levelBase + 1),         9,  7,  7,  10, 12, 10, 4,  9,  CharacterClasses.RedMage, TestWeapons.RedSword, TestArmour.SteelLight, TestAccessories.RedGem);
        public static PlayerEntity Freddie = new PlayerEntity("Freddie", (byte)(levelBase + 1),     9,  11, 8,  5,  6,  10, 12, 7,  CharacterClasses.Fighter, TestWeapons.DoubleBass, TestArmour.NiceSuit, TestAccessories.BowTie);
        public static PlayerEntity James = new PlayerEntity("James", (byte)(levelBase + 1),         6,  8,  11, 7,  12, 9,  6,  9,  CharacterClasses.WhiteMage, TestWeapons.IronStaff, TestArmour.WhiteRobes, TestAccessories.WhiteArmlet);

        public static List<PlayerEntity> Entities = new List<PlayerEntity> { Kazuma, Aqua, Megumin, Darkness, Wiz, Yunyun, Chris, Sam, Lewis, Freddie, James };
    }

    public class PlayerEntity : BaseEntity
    {
        public override ushort TotalHealthInc { get => (ushort)(Weapon.Increase.HealthInc + Armour.Increase.HealthInc + Accessory.Increase.HealthInc); }
        public override ushort TotalManaInc { get => (ushort)(Weapon.Increase.ManaInc + Armour.Increase.ManaInc + Accessory.Increase.ManaInc); }
        public override ushort TotalPhysAtkInc { get => (ushort)(Weapon.Increase.PhysAtkInc + Armour.Increase.PhysAtkInc + Accessory.Increase.PhysAtkInc); }
        public override ushort TotalPhysDefInc { get => (ushort)(Weapon.Increase.PhysDefInc + Armour.Increase.PhysDefInc + Accessory.Increase.PhysDefInc); }
        public override ushort TotalBlackMagInc { get => (ushort)(Weapon.Increase.BlackMagInc + Armour.Increase.BlackMagInc + Accessory.Increase.BlackMagInc); }
        public override ushort TotalWhiteMagInc { get => (ushort)(Weapon.Increase.WhiteMagInc + Armour.Increase.WhiteMagInc + Accessory.Increase.WhiteMagInc); }
        public override ushort TotalMagDefInc { get => (ushort)(Weapon.Increase.MagDefInc + Armour.Increase.MagDefInc + Accessory.Increase.MagDefInc); }
        public override ushort TotalHitRateInc { get => (ushort)(Weapon.Increase.HitRateInc + Armour.Increase.HitRateInc + Accessory.Increase.HitRateInc); }
        public override ushort TotalSpeedInc { get => (ushort)(Weapon.Increase.SpeedInc + Armour.Increase.SpeedInc + Accessory.Increase.SpeedInc); }
        public override ushort TotalCharmInc { get => (ushort)(Weapon.Increase.CharmInc + Armour.Increase.CharmInc + Accessory.Increase.CharmInc); }

        public override ushort MaxHealth { get => (ushort)Utils.Clamp((12 + baseVit) * level * 7 + baseLck * Math.Log(level) + TotalHealthInc, 1, 9999); }
        public override ushort MaxMana { get => (ushort)Utils.Clamp((baseInt + baseSpt + baseRes / 2) * level / 1.5 + baseLck * Math.Log(level) + TotalManaInc, 1, 999); }
        public override ushort PhysAtk { get => (ushort)Utils.Clamp(((baseStr + 10) * level / 2 + TotalPhysAtkInc) * PowerMultiplier, 1, 999); }
        public override ushort PhysDef { get => (ushort)Utils.Clamp((baseVit + 10) * level / 2 + TotalPhysDefInc, 1, 999); }
        public override ushort BlackMag { get => (ushort)Utils.Clamp((baseInt + (baseChr / 2)) * level / 1.5 + TotalBlackMagInc, 1, 999); }
        public override ushort WhiteMag { get => (ushort)Utils.Clamp((baseSpt + (baseChr / 2)) * level / 1.5 + TotalWhiteMagInc, 1, 999); }
        public override ushort MagDef { get => (ushort)Utils.Clamp((baseRes + (baseInt + baseSpt) / 4) * level / 1.5 + TotalMagDefInc, 1, 999); }
        public override ushort HitRate { get => (ushort)Utils.Clamp((6 + baseAgl + baseLck / 2) * level / 1.5 + TotalHitRateInc, 1, 999); }
        public override ushort Speed { get => (ushort)Utils.Clamp((6 + baseAgl + baseStr / 2) * level / 1.5 + TotalSpeedInc, 1, 999); }
        public override ushort Charm { get => (ushort)Utils.Clamp((6 + baseChr + baseLck / 2) * level / 1.5 + TotalCharmInc, 1, 999); }

        public Weapon Weapon { get; }
        public Armour Armour { get; }
        public Accessory Accessory { get; }

        public override double CritMultiplier { get => getCritMult(); }
        public override double HitMultiplier { get => getHitMult(); }
        public override double PowerMultiplier { get => getPowerMult(); }

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
            spells = new Dictionary<BaseSpell, byte>();
        }

        private double getCritMult()
        {
            if (Weapon != null)
                return Weapon.WType.crit;
            return base.CritMultiplier;
        }
        private double getHitMult()
        {
            if (Weapon != null)
                return Weapon.WType.hit;
            return base.HitMultiplier;
        }
        private double getPowerMult()
        {
            if (Weapon != null)
                return Weapon.WType.pow;
            return base.PowerMultiplier;
        }
    }
}
