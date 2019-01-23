using System;
using System.Collections.Generic;
using RPGExperiments;

namespace RPGExperiments.Equipment
{
    public static class TestWeapons
    {                                                                                        /* HP   MP   PA   PB   BM   WM   MD   HR   SP   CH */
        public static Weapon StaffOfRoses = new Weapon(WeaponTypes.Staff, new StatIncrease(     0,   0,   80,  0,   0,   220, 0,   0,   0,   0), "Staff of Roses");
        public static Weapon CrimsonWoodRod = new Weapon(WeaponTypes.Rod, new StatIncrease(     0,   0,   40,  0,   180, 0,   0,   0,   0,   0), "Crimson Wood Rod");
        public static Weapon CrimsonWand = new Weapon(WeaponTypes.Rod, new StatIncrease(        0,   0,   20,  0,   200, 0,   0,   0,   0,   0), "Crimson Wand");
        public static Weapon AzureStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(       0,   0,   50,  0,   110, 130, 0,   0,   0,   0), "Azure Staff");
        public static Weapon IronStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(        0,   0,   30,  0,   110, 110, 0,   0,   0,   0), "Iron Staff");
        public static Weapon MythrilShortsword = new Weapon(WeaponTypes.Sword, new StatIncrease(0,   0,   130, 0,   0,   0,   0,   0,   0,   0), "Mythril Shortsword");
        public static Weapon SteelBroadsword = new Weapon(WeaponTypes.Sword, new StatIncrease(  0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Steel Broadsword");
        public static Weapon CrystalDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(   0,   0,   200, 0,   0,   60,  0,   0,   0,   0), "Crystal Dagger");
        public static Weapon KnifeOfSilence = new Weapon(WeaponTypes.Dagger, new StatIncrease(  0,   0,   110, 0,   0,   0,   0,   0,   100, 0), "Knife of Silence");
        public static Weapon RedSword = new Weapon(WeaponTypes.Sword, new StatIncrease(         0,   0,   100, 0,   60,  80,  0,   0,   0,   0), "Red Sword");
        public static Weapon DoubleBass = new Weapon(WeaponTypes.Club, new StatIncrease(        0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Double Bass");
        public static Weapon SteelDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(     0,   0,   160, 0,   0,   0,   0,   0,   0,   0), "Steel Dagger");
        public static Weapon Fists = new Weapon(WeaponTypes.Unarmed, new StatIncrease(          0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "Fists");

        public static List<Weapon> Weapons = new List<Weapon> { StaffOfRoses, CrimsonWoodRod, CrimsonWand, AzureStaff, IronStaff, MythrilShortsword, SteelBroadsword, CrystalDagger, KnifeOfSilence, RedSword, DoubleBass };
    }

    public class Weapon : BaseEquipment
    {
        protected WeaponType wType;
        public WeaponType WType { get => wType; }

        public Weapon(WeaponType type_, StatIncrease increase_, string name_) : base(increase_, name_)
        {
            wType = type_;
        }
    }
}
