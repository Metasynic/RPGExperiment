
namespace RPGExperiments.Equipment
{
    public static class TestAccessories
    {                                                                         /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Accessory None = new Accessory(new StatIncrease(           0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "None");
        public static Accessory StealSash = new Accessory(new StatIncrease(      0,   0,   0,   0,   0,   0,   0,   40,  20,  0), "Steal Sash");
        public static Accessory GoddessRibbon = new Accessory(new StatIncrease(  0,   0,   0,   0,   0,   0,   0,   0,   0,   80), "Goddess Ribbon");
        public static Accessory CrimsonEyepatch = new Accessory(new StatIncrease(0,   0,   0,   0,   60,  0,   0,   0,   0,   0), "Crimson Eyepatch");
        public static Accessory PaladinBadge = new Accessory(new StatIncrease(   0,   0,   20,  60,  0,   0,   0,   0,   0,   0), "Paladin Badge");
        public static Accessory LichBadge = new Accessory(new StatIncrease(      0,   0,   0,   0,   20,  20,  20,  0,   0,   0), "Lich Badge");
        public static Accessory CrimsonRibbon = new Accessory(new StatIncrease(  0,   0,   0,   0,   60,  0,   0,   0,   0,   0), "Crimson Ribbon");
        public static Accessory RuneAmulet = new Accessory(new StatIncrease(     0,   0,   0,   40,  0,   0,   40,  0,   0,   0), "Rune Amulet");
        public static Accessory AzureCape = new Accessory(new StatIncrease(      0,   0.1, 0,   0,   0,   0,   0,   0,   0,   0), "Azure Cape");
        public static Accessory RedGem = new Accessory(new StatIncrease(         0,   0,   20,  0,   20,  20,  0,   0,   0,   0), "Red Gem");
        public static Accessory BowTie = new Accessory(new StatIncrease(         0,   0,   0,   0,   0,   0,   0,   0,   0,   60), "Bow Tie");
        public static Accessory WhiteArmlet = new Accessory(new StatIncrease(    0,   0,   0,   0,   0,   40,  0,   0,   0,   0), "White Armlet");
    }

    public class Accessory : BaseEquipment
    {
        public Accessory(StatIncrease increase_, string name_) : base(increase_, name_)
        {

        }
    }
}
