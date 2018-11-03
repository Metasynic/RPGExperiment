using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments
{
    public static class WeaponTypes
    {
        public static readonly WeaponType Sword = new WeaponType(1.0, 1.0, 1d/16d);
        public static readonly WeaponType Dagger = new WeaponType(0.85, 0.8, 1d/16d);
        public static readonly WeaponType Spear = new WeaponType(1.25, 0.8, 1d/16d);
        public static readonly WeaponType Axe = new WeaponType(0.75, 1.25, 1d/16d);
        public static readonly WeaponType Staff = new WeaponType(1.0, 0.5, 1d/32d);
        public static readonly WeaponType Club = new WeaponType(0.8, 1.2, 1d/32d);
        public static readonly WeaponType Rod = new WeaponType(0.85, 0.4, 1d/32d);
        public static readonly WeaponType Bow = new WeaponType(0.9, 0.85, 1d/8d);
    }

    public struct WeaponType
    {
        // These are ratings between 0 and 1 for modifying weapon power and hit rate.
        public double hit { get; }
        public double pow { get; }
        public double crit { get; }

        public WeaponType(double h, double p, double c)
        {
            hit = h;
            pow = p;
            crit = c;
        }
    }
}
