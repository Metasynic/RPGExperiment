using System;
using System.Collections.Generic;
using RPGExperiments;

namespace RPGExperiments.Weapons
{
    public static class TestMagWeapons
    {
        public static MagWeapon StaffOfRoses = new MagWeapon(WeaponTypes.Staff, 20, "Staff of Roses");
        public static MagWeapon CrimsonWoodRod = new MagWeapon(WeaponTypes.Rod, 9, "Crimson Wood Rod");

        public static MagWeapon CrimsonWand = new MagWeapon(WeaponTypes.Rod, 14, "Crimson Wand");

        public static MagWeapon AzureStaff = new MagWeapon(WeaponTypes.Staff, 16, "Azure Staff");
        public static MagWeapon IronStaff = new MagWeapon(WeaponTypes.Staff, 7, "Iron Staff");

        public static List<MagWeapon> MagWeapons = new List<MagWeapon> { StaffOfRoses, CrimsonWoodRod, CrimsonWand, AzureStaff, IronStaff };
    }

    public class MagWeapon : BaseWeapon
    {
        public override byte PhysPower { get => 0; }
        public override byte MagPower { get => power; }

        public MagWeapon(WeaponType type_, byte power_, string name_) : base(type_, power_, name_)
        {

        }
    }
}
