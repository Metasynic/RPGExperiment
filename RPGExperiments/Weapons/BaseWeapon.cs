using System;

namespace RPGExperiments.Weapons
{
    public abstract class BaseWeapon
    {
        /* Goes from 1 to 32. Represents attacking modifier for the weapon based on quality.
         * 1-5: Barely qualifies as a weapon.
         * 6-10: Very basic starting equipment.
         * 11-15: Common weaponry available at most shops.
         * 16-20: Uncommon, well-crafted weapons such as monster drops.
         * 21-25: Rare and specialist/magical weapons, expensive to obtain.
         * 26-30: One-of-a-kind equipment, such as boss drops.
         * 31-32: A weapon imbued with sacred or legendary power. */
        public abstract byte PhysPower { get; }
        public abstract byte MagPower { get; }

        protected WeaponType wType;
        public WeaponType WType { get => wType; }

        protected byte power;
        public byte Power { get => power; }

        protected string name;
        public string Name { get => name; }

        public BaseWeapon(WeaponType type_, byte power_, string name_)
        {
            wType = type_;
            power = power_;
            name = name_;
        }
    }
}
