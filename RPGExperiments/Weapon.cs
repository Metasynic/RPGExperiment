using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments
{
    public static class TestWeapons
    {
        public static Weapon MythrilShortsword = new Weapon(WeaponTypes.Sword, 22, "Mythril Shortsword");
        public static Weapon StaffOfRoses = new Weapon(WeaponTypes.Staff, 13, "Staff of Roses");
        public static Weapon CrimsonWoodRod = new Weapon(WeaponTypes.Rod, 6, "Crimson Wood Rod");
        public static Weapon SteelBroadsword = new Weapon(WeaponTypes.Sword, 19, "Steel Broadsword");

        public static Weapon CrystalDagger = new Weapon(WeaponTypes.Dagger, 27, "Crystal Dagger");
        public static Weapon CrimsonWand = new Weapon(WeaponTypes.Rod, 11, "Crimson Wand");
        public static Weapon KnifeOfSilence = new Weapon(WeaponTypes.Dagger, 21, "Knife of Silence");

        public static Weapon AzureSword = new Weapon(WeaponTypes.Sword, 23, "Azure Sword");
        public static Weapon RedSword = new Weapon(WeaponTypes.Sword, 22, "Red Sword");
        public static Weapon DoubleBass = new Weapon(WeaponTypes.Club, 31, "Double Bass");
        public static Weapon IronStaff = new Weapon(WeaponTypes.Staff, 11, "Iron Staff");

        public static List<Weapon> Weapons = new List<Weapon> { MythrilShortsword, StaffOfRoses, CrimsonWoodRod, SteelBroadsword, CrystalDagger, CrimsonWand, KnifeOfSilence, AzureSword, RedSword, DoubleBass, IronStaff };
    }

    public class Weapon
    {
        /* Goes from 1 to 32. Represents attacking modifier for the weapon based on quality.
         * 1-5: Barely qualifies as a weapon.
         * 6-10: Very basic starting equipment.
         * 11-15: Common weaponry available at most shops.
         * 16-20: Uncommon, well-crafted weapons such as monster drops.
         * 21-25: Rare and specialist/magical weapons, expensive to obtain.
         * 26-30: One-of-a-kind equipment, such as boss drops.
         * 31-32: A weapon imbued with sacred or legendary power. */
        private WeaponType wType;
        public WeaponType WType { get => wType; }

        private byte power;
        public byte Power { get => power; }

        private string name;
        public string Name { get => name; }

        public Weapon(WeaponType type_, byte power_, string name_)
        {
            wType = type_;
            power = power_;
            name = name_;
        }
    }
}
