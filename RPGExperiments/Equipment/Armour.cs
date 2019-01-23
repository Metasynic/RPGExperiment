using System.Collections.Generic;

namespace RPGExperiments.Equipment
{
    public static class TestArmour
    {                                                                  /* HP   MP   PA   PB   BM   WM   MD   HR   SP   CH */
        public static Armour ThiefCape = new Armour(new StatIncrease(     0,   0,   0,   50,  0,   0,   50,  40,  0,   0), "Thief Cape");
        public static Armour GoddessSuit = new Armour(new StatIncrease(   0,   0,   0,   60,  0,   0,   200, 0,   0,   0), "Goddess Suit");
        public static Armour CrimsonHat = new Armour(new StatIncrease(    0,   0,   0,   20,  0,   0,   120, 0,   0,   0), "Crimson Cape");
        public static Armour CrusaderHeavy = new Armour(new StatIncrease( 0,   0,   0,   200, 0,   0,   100, 0,   0,   0), "Crusader Heavy");
        public static Armour PurpleRobes = new Armour(new StatIncrease(   0,   0,   0,   40,  0,   0,   130, 0,   0,   0), "Purple Robes");
        public static Armour CrimsonUniform = new Armour(new StatIncrease(0,   0,   0,   40,  0,   0,   90,  0,   0,   0), "School Uniform");
        public static Armour ThiefSuit = new Armour(new StatIncrease(     0,   0,   0,   60,  0,   0,   70,  0,   0,   0), "Thief Suit");
        public static Armour AzureCloak = new Armour(new StatIncrease(    0,   0,   0,   30,  0,   0,   80,  0,   0,   0), "Azure Cloak");
        public static Armour SteelLight = new Armour(new StatIncrease(    0,   0,   0,   120, 0,   0,   30,  0,   0,   0), "Steel Light");
        public static Armour NiceSuit = new Armour(new StatIncrease(      0,   0,   0,   20,  0,   0,   20,  0,   0,   0), "Nice Suit");
        public static Armour WhiteRobes = new Armour(new StatIncrease(    0,   0,   0,   40,  0,   20,  110, 0,   0,   0), "White Robes");
        public static Armour Clothes = new Armour(new StatIncrease(       0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "Clothes");

        public static List<Armour> Armour = new List<Armour> {ThiefCape, GoddessSuit, CrimsonHat, CrusaderHeavy, PurpleRobes, CrimsonUniform, ThiefSuit, AzureCloak, SteelLight, NiceSuit, WhiteRobes};
    }

    public class Armour : BaseEquipment
    {
        public Armour(StatIncrease increase_, string name_) : base(increase_, name_)
        {

        }
    }
}
