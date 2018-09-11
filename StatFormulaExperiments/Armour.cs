using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatFormulaExperiments
{
    public static class TestArmour
    {
        public static ArmourPiece ThiefCape = new ArmourPiece(12, "Thief Cape");
        public static ArmourPiece GoddessSuit = new ArmourPiece(18, "Goddess Suit");
        public static ArmourPiece CrimsonHat = new ArmourPiece(16, "Crimson Cape");
        public static ArmourPiece CrusaderHeavy = new ArmourPiece(25, "Crusader Heavy");

        public static ArmourPiece PurpleRobes = new ArmourPiece(11, "Purple Robes");
        public static ArmourPiece CrimsonUniform = new ArmourPiece(17, "School Uniform");
        public static ArmourPiece ThiefSuit = new ArmourPiece(13, "Thief Suit");

        public static ArmourPiece AzureCloak = new ArmourPiece(21, "Azure Cloak");
        public static ArmourPiece SteelLight = new ArmourPiece(19, "Steel Light");
        public static ArmourPiece NiceSuit = new ArmourPiece(2, "Nice Suit");
        public static ArmourPiece WhiteRobes = new ArmourPiece(11, "White Robes");

        public static List<ArmourPiece> Armour = new List<ArmourPiece> {ThiefCape, GoddessSuit, CrimsonHat, CrusaderHeavy, PurpleRobes, CrimsonUniform, ThiefSuit, AzureCloak, SteelLight, NiceSuit, WhiteRobes};
    }

    public class ArmourPiece
    {
        /* Goes from 1 to 32. Represents defensive capability of the armour.
         * 1-5: Barely qualifies as armour.
         * 6-10: Very basic starting equipment.
         * 11-15: Common armour available at most shops.
         * 16-20: Uncommon, well-crafted armour such as monster drops.
         * 21-25: Rare and specialist/magical armour, expensive to obtain.
         * 26-30: One-of-a-kind equipment, such as boss drops.
         * 31-32: An armour piece imbued with sacred or legendary power. */
        private byte protection;
        public byte Protection { get => protection; }

        private string name;
        public string Name { get => name; }

        public ArmourPiece(byte protection_, string name_)
        {
            protection = protection_;
            name = name_;
        }
    }
}
