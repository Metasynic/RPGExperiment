using System.Collections.Generic;

namespace RPGExperiments.Equipment
{
    public static class TestArmour
    {                                                                                            /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour ThiefCape = new Armour(ArmourTypes.LightOutfit, new StatIncrease(      0,   0,   0,   50,  0,   0,   50,  40,  0,   0), "Thief Cape");
        public static Armour GoddessSuit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(   0,   0,   0,   60,  0,   0,   200, 0,   0,   0), "Goddess Suit");
        public static Armour CrimsonHat = new Armour(ArmourTypes.LightRobes, new StatIncrease(      0,   0,   0,   20,  0,   0,   120, 0,   0,   0), "Crimson Cape");
        public static Armour CrusaderHeavy = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(  0,   0,   0,   200, 0,   0,   100, 0,   0,   0), "Crusader Heavy");
        public static Armour PurpleRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(     0,   0,   0,   40,  0,   0,   130, 0,   0,   0), "Purple Robes");
        public static Armour CrimsonUniform = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   40,  0,   0,   90,  0,   0,   0), "School Uniform");
        public static Armour ThiefSuit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(      0,   0,   0,   60,  0,   0,   70,  0,   0,   0), "Thief Suit");
        public static Armour AzureCloak = new Armour(ArmourTypes.LightRobes, new StatIncrease(      0,   0,   0,   30,  0,   0,   80,  0,   0,   0), "Azure Cloak");
        public static Armour SteelLight = new Armour(ArmourTypes.LightArmour, new StatIncrease(     0,   0,   0,   120, 0,   0,   30,  0,   0,   0), "Steel Light");
        public static Armour NiceSuit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(      0,   0,   0,   20,  0,   0,   20,  0,   0,   0), "Nice Suit");
        public static Armour WhiteRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(      0,   0,   0,   40,  0,   20,  110, 0,   0,   0), "White Robes");
        public static Armour Clothes = new Armour(ArmourTypes.Unarmoured, new StatIncrease(         0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "Clothes");

        public static List<Armour> Armour = new List<Armour> {ThiefCape, GoddessSuit, CrimsonHat, CrusaderHeavy, PurpleRobes, CrimsonUniform, ThiefSuit, AzureCloak, SteelLight, NiceSuit, WhiteRobes};
    }

    public class Armour : BaseEquipment
    {
        protected ArmourType aType;
        public ArmourType AType { get => aType; }

        public Armour(ArmourType type_, StatIncrease increase_, string name_) : base(increase_, name_)
        {
            aType = type_;
        }
    }
}
