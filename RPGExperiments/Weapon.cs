using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments
{
    public static class TestWeapons
    {
        public static MeleeWeapon MythrilShortsword = new MeleeWeapon(22, "Mythril Shortsword");
        public static MeleeWeapon StaffOfRoses = new MeleeWeapon(13, "Staff of Roses");
        public static MeleeWeapon CrimsonWoodRod = new MeleeWeapon(6, "Crimson Wood Rod");
        public static MeleeWeapon SteelBroadsword = new MeleeWeapon(19, "Steel Broadsword");

        public static MeleeWeapon CrystalDaggers = new MeleeWeapon(27, "Crystal Daggers");
        public static MeleeWeapon CrimsonWand = new MeleeWeapon(11, "Crimson Black Rod");
        public static MeleeWeapon KnifeOfSilence = new MeleeWeapon(21, "Knife of Silence");

        public static MeleeWeapon AzureSword = new MeleeWeapon(23, "Azure Sword");
        public static MeleeWeapon RedSword = new MeleeWeapon(22, "Red Sword");
        public static MeleeWeapon DoubleBass = new MeleeWeapon(31, "Double Bass");
        public static MeleeWeapon IronStaff = new MeleeWeapon(11, "Iron Staff");

        public static List<MeleeWeapon> Weapons = new List<MeleeWeapon> {MythrilShortsword, StaffOfRoses, CrimsonWoodRod, SteelBroadsword, CrystalDaggers, CrimsonWand, KnifeOfSilence, AzureSword, RedSword, DoubleBass, IronStaff};
    }

    public class MeleeWeapon
    {
        /* Goes from 1 to 32. Represents attacking modifier for the weapon.
         * 1-5: Barely qualifies as a weapon.
         * 6-10: Very basic starting equipment.
         * 11-15: Common weaponry available at most shops.
         * 16-20: Uncommon, well-crafted weapons such as monster drops.
         * 21-25: Rare and specialist/magical weapons, expensive to obtain.
         * 26-30: One-of-a-kind equipment, such as boss drops.
         * 31-32: A weapon imbued with sacred or legendary power. */
        private byte power;
        public byte Power { get => power; }

        private string name;
        public string Name { get => name; }

        public MeleeWeapon(byte power_, string name_)
        {
            power = power_;
            name = name_;
        }
    }
}
