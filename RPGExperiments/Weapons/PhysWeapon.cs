using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments.Weapons
{
    public static class TestPhysWeapons
    {
        public static PhysWeapon MythrilShortsword = new PhysWeapon(WeaponTypes.Sword, 22, "Mythril Shortsword");
        public static PhysWeapon SteelBroadsword = new PhysWeapon(WeaponTypes.Sword, 19, "Steel Broadsword");

        public static PhysWeapon CrystalDagger = new PhysWeapon(WeaponTypes.Dagger, 27, "Crystal Dagger");
        public static PhysWeapon KnifeOfSilence = new PhysWeapon(WeaponTypes.Dagger, 21, "Knife of Silence");

        public static PhysWeapon RedSword = new PhysWeapon(WeaponTypes.Sword, 18, "Red Sword");
        public static PhysWeapon DoubleBass = new PhysWeapon(WeaponTypes.Club, 31, "Double Bass");

        public static List<PhysWeapon> PhysWeapons = new List<PhysWeapon> { MythrilShortsword, SteelBroadsword, CrystalDagger, KnifeOfSilence, RedSword, DoubleBass };
    }

    public class PhysWeapon : BaseWeapon
    {
        public override byte PhysPower { get => power; }
        public override byte MagPower { get => 0; }

        public PhysWeapon(WeaponType type_, byte power_, string name_) : base(type_, power_, name_)
        {

        }
    }
}
