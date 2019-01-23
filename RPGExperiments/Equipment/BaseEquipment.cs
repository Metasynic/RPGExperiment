using System;

namespace RPGExperiments.Equipment
{
    public struct StatIncrease
    {
        public readonly double HealthInc, ManaInc;
        public readonly ushort PhysAtkInc, PhysDefInc, BlackMagInc, WhiteMagInc, MagDefInc, HitRateInc, SpeedInc, CharmInc;

        public StatIncrease(double healthInc, double manaInc, ushort physAtkInc, ushort physDefInc, ushort blackMagInc, ushort whiteMagInc, ushort magDefInc, ushort hitRateInc, ushort speedInc, ushort charmInc)
        {
            HealthInc = healthInc;
            ManaInc = manaInc;
            PhysAtkInc = physAtkInc;
            PhysDefInc = physDefInc;
            BlackMagInc = blackMagInc;
            WhiteMagInc = whiteMagInc;
            MagDefInc = magDefInc;
            HitRateInc = hitRateInc;
            SpeedInc = speedInc;
            CharmInc = charmInc;
        }
    }

    public abstract class BaseEquipment
    {
        /* Goes from 0 to 300. Represents stat increase based on quality.
         * 0-60: Very basic starting equipment.
         * 61-120: Common weaponry available at most shops.
         * 121-180: Uncommon, well-crafted weapons such as monster drops.
         * 181-240: Rare and specialist/magical weapons, expensive to obtain.
         * 241-300: One-of-a-kind equipment, such as boss drops. 
         * [NB: Divide all by 3 for accessory increases, which should be capped at 100.] 
         * Also, HP and MP increases represent a multiplicative factor to be added to 1. */

        protected StatIncrease increase;
        public StatIncrease Increase { get => increase; }

        protected string name;
        public string Name { get => name; }

        protected BaseEquipment(StatIncrease increase_, string name_)
        {
            increase = increase_;
            name = name_;
        }
    }
}
