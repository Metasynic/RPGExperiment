
namespace RPGExperiments.Equipment
{
    public static class ArmourTypes
    {
        public static readonly ArmourType Unarmoured = new ArmourType(1.0, 1.0, 1.0);
        public static readonly ArmourType LightArmour = new ArmourType(1.1, 1.0, 0.8);
        public static readonly ArmourType HeavyArmour = new ArmourType(1.2, 1.0, 0.6);
        public static readonly ArmourType Gi = new ArmourType(1.4, 1.0, 1.0);
        public static readonly ArmourType LightOutfit = new ArmourType(1.05, 1.05, 1.0);
        public static readonly ArmourType MediumOutfit = new ArmourType(1.1, 1.1, 0.9);
        public static readonly ArmourType LightRobes = new ArmourType(1.0, 1.1, 1.0);
        public static readonly ArmourType HeavyRobes = new ArmourType(1.0, 1.2, 0.8);
    }

    public struct ArmourType
    {
        // These are ratings between 0 and 1 for modifying armour defenses and mobility penalty.
        public double PhysDef { get; }
        public double MagDef { get; }
        public double Mobility { get; }

        public ArmourType(double pd, double md, double m)
        {
            PhysDef = pd;
            MagDef = md;
            Mobility = m;
        }
    }
}
