using System;
using System.Collections.Generic;
using RPGExperiments;

namespace RPGExperiments.Weapons
{
    public static class TestMagWeapons
    {
        public static MagWeapon StaffOfRoses = new MagWeapon(WeaponTypes.Staff, 13, "Staff of Roses");
        public static MagWeapon CrimsonWoodRod = new MagWeapon(WeaponTypes.Rod, 6, "Crimson Wood Rod");

        public static MagWeapon CrimsonWand = new MagWeapon(WeaponTypes.Rod, 11, "Crimson Wand");

        public static MagWeapon IronStaff = new MagWeapon(WeaponTypes.Staff, 11, "Iron Staff");

        public static List<MagWeapon> MagWeapons = new List<MagWeapon> { StaffOfRoses, CrimsonWoodRod, CrimsonWand, IronStaff };
    }

    public class MagWeapon : BaseWeapon
    {
        public MagWeapon(WeaponType type_, byte power_, string name_) : base(type_, power_, name_)
        {

        }
    }
}
