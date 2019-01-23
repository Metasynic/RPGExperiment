using System.Collections.Generic;

namespace RPGExperiments.Equipment
{
    public static class TestWeapons
    {                                                                                              /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon None = new Weapon(WeaponTypes.Unarmed, new StatIncrease(                 0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "None");

        public static Weapon TrainingShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Shortsword");
        public static Weapon IronShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Shortsword");
        public static Weapon SteelShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Shortsword");
        public static Weapon MythrilShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Shortsword");
        public static Weapon JadeShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Shortsword");
        public static Weapon CrystalShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Shortsword");
        public static Weapon AdamantShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Shortsword");
        public static Weapon StellarShortsword = new Weapon(WeaponTypes.Shortsword, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Shortsword");
        public static List<Weapon> Shortswords = new List<Weapon> { TrainingShortsword, IronShortsword, SteelShortsword, MythrilShortsword, JadeShortsword, CrystalShortsword, AdamantShortsword, StellarShortsword };

                                                                                                   /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Broadsword");
        public static Weapon IronBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Broadsword");
        public static Weapon SteelBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Broadsword");
        public static Weapon MythrilBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Broadsword");
        public static Weapon JadeBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Broadsword");
        public static Weapon CrystalBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Broadsword");
        public static Weapon AdamantBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Broadsword");
        public static Weapon StellarBroadsword = new Weapon(WeaponTypes.Broadsword, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Broadsword");
        public static List<Weapon> Broadswords = new List<Weapon> { TrainingBroadsword, IronBroadsword, SteelBroadsword, MythrilBroadsword, JadeBroadsword, CrystalBroadsword, AdamantBroadsword, StellarBroadsword };

                                                                                           /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Dagger");
        public static Weapon IronDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Dagger");
        public static Weapon SteelDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Dagger");
        public static Weapon MythrilDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Dagger");
        public static Weapon JadeDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Dagger");
        public static Weapon CrystalDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Dagger");
        public static Weapon AdamantDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Dagger");
        public static Weapon StellarDagger = new Weapon(WeaponTypes.Dagger, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Dagger");
        public static List<Weapon> Daggers = new List<Weapon> { TrainingDagger, IronDagger, SteelDagger, MythrilDagger, JadeDagger, CrystalDagger, AdamantDagger, StellarDagger };

                                                                                          /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingSpear = new Weapon(WeaponTypes.Spear, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Spear");
        public static Weapon IronSpear = new Weapon(WeaponTypes.Spear, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Spear");
        public static Weapon SteelSpear = new Weapon(WeaponTypes.Spear, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Spear");
        public static Weapon MythrilSpear = new Weapon(WeaponTypes.Spear, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Spear");
        public static Weapon JadeSpear = new Weapon(WeaponTypes.Spear, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Spear");
        public static Weapon CrystalSpear = new Weapon(WeaponTypes.Spear, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Spear");
        public static Weapon AdamantSpear = new Weapon(WeaponTypes.Spear, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Spear");
        public static Weapon StellarSpear = new Weapon(WeaponTypes.Spear, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Spear");
        public static List<Weapon> Spears = new List<Weapon> { TrainingSpear, IronSpear, SteelSpear, MythrilSpear, JadeSpear, CrystalSpear, AdamantSpear, StellarSpear };

                                                                                     /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingAxe = new Weapon(WeaponTypes.Axe, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Axe");
        public static Weapon IronAxe = new Weapon(WeaponTypes.Axe, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Axe");
        public static Weapon SteelAxe = new Weapon(WeaponTypes.Axe, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Axe");
        public static Weapon MythrilAxe = new Weapon(WeaponTypes.Axe, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Axe");
        public static Weapon JadeAxe = new Weapon(WeaponTypes.Axe, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Axe");
        public static Weapon CrystalAxe = new Weapon(WeaponTypes.Axe, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Axe");
        public static Weapon AdamantAxe = new Weapon(WeaponTypes.Axe, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Axe");
        public static Weapon StellarAxe = new Weapon(WeaponTypes.Axe, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Axe");
        public static List<Weapon> Axes = new List<Weapon> { TrainingAxe, IronAxe, SteelAxe, MythrilAxe, JadeAxe, CrystalAxe, AdamantAxe, StellarAxe };

                                                                                     /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingBow = new Weapon(WeaponTypes.Bow, new StatIncrease(0,   0,   30,  0,   0,   0,   0,   0,   0,   0), "Training Bow");
        public static Weapon IronBow = new Weapon(WeaponTypes.Bow, new StatIncrease(    0,   0,   60,  0,   0,   0,   0,   0,   0,   0), "Iron Bow");
        public static Weapon SteelBow = new Weapon(WeaponTypes.Bow, new StatIncrease(   0,   0,   90,  0,   0,   0,   0,   0,   0,   0), "Steel Bow");
        public static Weapon MythrilBow = new Weapon(WeaponTypes.Bow, new StatIncrease( 0,   0,   120, 0,   0,   0,   0,   0,   0,   0), "Mythril Bow");
        public static Weapon JadeBow = new Weapon(WeaponTypes.Bow, new StatIncrease(    0,   0,   150, 0,   0,   0,   0,   0,   0,   0), "Jade Bow");
        public static Weapon CrystalBow = new Weapon(WeaponTypes.Bow, new StatIncrease( 0,   0,   180, 0,   0,   0,   0,   0,   0,   0), "Crystal Bow");
        public static Weapon AdamantBow = new Weapon(WeaponTypes.Bow, new StatIncrease( 0,   0,   210, 0,   0,   0,   0,   0,   0,   0), "Adamant Bow");
        public static Weapon StellarBow = new Weapon(WeaponTypes.Bow, new StatIncrease( 0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Stellar Bow");
        public static List<Weapon> Bows = new List<Weapon> { TrainingBow, IronBow, SteelBow, MythrilBow, JadeBow, CrystalBow, AdamantBow, StellarBow };

                                                                                         /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(0,   0,   0,   0,   0,   30,  0,   0,   0,   0), "Training Staff");
        public static Weapon IronStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(    0,   0,   0,   0,   0,   60,  0,   0,   0,   0), "Iron Staff");
        public static Weapon SteelStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(   0,   0,   0,   0,   0,   90,  0,   0,   0,   0), "Steel Staff");
        public static Weapon MythrilStaff = new Weapon(WeaponTypes.Staff, new StatIncrease( 0,   0,   0,   0,   0,   120, 0,   0,   0,   0), "Mythril Staff");
        public static Weapon JadeStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(    0,   0,   0,   0,   0,   150, 0,   0,   0,   0), "Jade Staff");
        public static Weapon CrystalStaff = new Weapon(WeaponTypes.Staff, new StatIncrease( 0,   0,   0,   0,   0,   180, 0,   0,   0,   0), "Crystal Staff");
        public static Weapon AdamantStaff = new Weapon(WeaponTypes.Staff, new StatIncrease( 0,   0,   0,   0,   0,   210, 0,   0,   0,   0), "Adamant Staff");
        public static Weapon StellarStaff = new Weapon(WeaponTypes.Staff, new StatIncrease( 0,   0,   0,   0,   0,   240, 0,   0,   0,   0), "Stellar Staff");
        public static List<Weapon> Staffs = new List<Weapon> { TrainingStaff, IronStaff, SteelStaff, MythrilStaff, JadeStaff, CrystalStaff, AdamantStaff, StellarStaff };

                                                                                     /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon TrainingRod = new Weapon(WeaponTypes.Rod, new StatIncrease(0,   0,   0,   0,   30,  0,   0,   0,   0,   0), "Training Rod");
        public static Weapon IronRod = new Weapon(WeaponTypes.Rod, new StatIncrease(    0,   0,   0,   0,   60,  0,   0,   0,   0,   0), "Iron Rod");
        public static Weapon SteelRod = new Weapon(WeaponTypes.Rod, new StatIncrease(   0,   0,   0,   0,   90,  0,   0,   0,   0,   0), "Steel Rod");
        public static Weapon MythrilRod = new Weapon(WeaponTypes.Rod, new StatIncrease( 0,   0,   0,   0,   120, 0,   0,   0,   0,   0), "Mythril Rod");
        public static Weapon JadeRod = new Weapon(WeaponTypes.Rod, new StatIncrease(    0,   0,   0,   0,   150, 0,   0,   0,   0,   0), "Jade Rod");
        public static Weapon CrystalRod = new Weapon(WeaponTypes.Rod, new StatIncrease( 0,   0,   0,   0,   180, 0,   0,   0,   0,   0), "Crystal Rod");
        public static Weapon AdamantRod = new Weapon(WeaponTypes.Rod, new StatIncrease( 0,   0,   0,   0,   210, 0,   0,   0,   0,   0), "Adamant Rod");
        public static Weapon StellarRod = new Weapon(WeaponTypes.Rod, new StatIncrease( 0,   0,   0,   0,   240, 0,   0,   0,   0,   0), "Stellar Rod");
        public static List<Weapon> Rods = new List<Weapon> { TrainingRod, IronRod, SteelRod, MythrilRod, JadeRod, CrystalRod, AdamantRod, StellarRod };

                                                                                           /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Weapon StaffOfRoses = new Weapon(WeaponTypes.Staff, new StatIncrease(   0,   0,   80,  0,   0,   220, 0,   0,   0,   0), "Staff of Roses");
        public static Weapon CrimsonWoodRod = new Weapon(WeaponTypes.Rod, new StatIncrease(   0,   0,   40,  0,   180, 0,   0,   0,   0,   0), "Crimson Wood Rod");
        public static Weapon CrimsonWand = new Weapon(WeaponTypes.Rod, new StatIncrease(      0,   0,   20,  0,   200, 0,   0,   0,   0,   0), "Crimson Wand");
        public static Weapon AzureStaff = new Weapon(WeaponTypes.Staff, new StatIncrease(     0,   0,   50,  0,   110, 130, 0,   0,   0,   0), "Azure Staff");
        public static Weapon KnifeOfSilence = new Weapon(WeaponTypes.Dagger, new StatIncrease(0,   0,   110, 0,   0,   0,   0,   0,   100, 0), "Knife of Silence");
        public static Weapon RedSword = new Weapon(WeaponTypes.Shortsword, new StatIncrease(  0,   0,   100, 0,   60,  80,  0,   0,   0,   0), "Red Sword");
        public static Weapon DoubleBass = new Weapon(WeaponTypes.Axe, new StatIncrease(       0,   0,   240, 0,   0,   0,   0,   0,   0,   0), "Double Bass");

        public static Weapon MonkFists = new Weapon(WeaponTypes.Fists, new StatIncrease(      0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "Monk Fists");

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
