using System.Collections.Generic;

namespace RPGExperiments.Equipment
{
    public static class TestArmour
    {                          
                                                                                     /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour None = new Armour(ArmourTypes.Unarmoured, new StatIncrease(0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "None");

                                                                                                    /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour LightLeatherArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Light Leather Armour");
        public static Armour LightIronArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Light Iron Armour");
        public static Armour LightSteelArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Light Steel Armour");
        public static Armour LightMythrilArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Light Mythril Armour");
        public static Armour LightJadeArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Light Jade Armour");
        public static Armour LightCrystalArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(0,   0,   0,   180, 0,   0,   210, 0,   0,   0), "Light Crystal Armour");
        public static Armour LightAdamantArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(0,   0,   0,   210, 0,   0,   240, 0,   0,   0), "Light Adamant Armour");
        public static Armour LightStellarArmour = new Armour(ArmourTypes.LightArmour, new StatIncrease(0,   0,   0,   240, 0,   0,   270, 0,   0,   0), "Light Stellar Armour");
        public static List<Armour> LightArmours = new List<Armour> { LightLeatherArmour, LightIronArmour, LightSteelArmour, LightMythrilArmour, LightJadeArmour, LightCrystalArmour, LightAdamantArmour, LightStellarArmour };

                                                                                                    /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour HeavyLeatherArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Heavy Leather Armour");
        public static Armour HeavyIronArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Heavy Iron Armour");
        public static Armour HeavySteelArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Heavy Steel Armour");
        public static Armour HeavyMythrilArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Heavy Mythril Armour");
        public static Armour HeavyJadeArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Heavy Jade Armour");
        public static Armour HeavyCrystalArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(0,   0,   0,   180, 0,   0,   180, 0,   0,   0), "Heavy Crystal Armour");
        public static Armour HeavyAdamantArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(0,   0,   0,   210, 0,   0,   210, 0,   0,   0), "Heavy Adamant Armour");
        public static Armour HeavyStellarArmour = new Armour(ArmourTypes.HeavyArmour, new StatIncrease(0,   0,   0,   240, 0,   0,   240, 0,   0,   0), "Heavy Stellar Armour");
        public static List<Armour> HeavyArmours = new List<Armour> { HeavyLeatherArmour, HeavyIronArmour, HeavySteelArmour, HeavyMythrilArmour, HeavyJadeArmour, HeavyCrystalArmour, HeavyAdamantArmour, HeavyStellarArmour };

                                                                                                         /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour LightLeatherBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Light Leather-bound Outfit");
        public static Armour LightIronBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Light Iron-bound Outfit");
        public static Armour LightSteelBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Light Steel-bound Outfit");
        public static Armour LightMythrilBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Light Mythril-bound Outfit");
        public static Armour LightJadeBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Light Jade-bound Outfit");
        public static Armour LightCrystalBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(0,   0,   0,   180, 0,   0,   180, 0,   0,   0), "Light Crystal-bound Outfit");
        public static Armour LightAdamantBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(0,   0,   0,   210, 0,   0,   210, 0,   0,   0), "Light Adamant-bound Outfit");
        public static Armour LightStellarBoundOutfit = new Armour(ArmourTypes.LightOutfit, new StatIncrease(0,   0,   0,   240, 0,   0,   240, 0,   0,   0), "Light Stellar-bound Outfit");
        public static List<Armour> LightOutfits = new List<Armour> { LightLeatherBoundOutfit, LightIronBoundOutfit, LightSteelBoundOutfit, LightMythrilBoundOutfit, LightJadeBoundOutfit, LightCrystalBoundOutfit, LightAdamantBoundOutfit, LightStellarBoundOutfit };

                                                                                                           /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour MediumLeatherBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Medium Leather-bound Outfit");
        public static Armour MediumIronBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Medium Iron-bound Outfit");
        public static Armour MediumSteelBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Medium Steel-bound Outfit");
        public static Armour MediumMythrilBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Medium Mythril-bound Outfit");
        public static Armour MediumJadeBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Medium Jade-bound Outfit");
        public static Armour MediumCrystalBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   180, 0,   0,   180, 0,   0,   0), "Medium Crystal-bound Outfit");
        public static Armour MediumAdamantBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   210, 0,   0,   210, 0,   0,   0), "Medium Adamant-bound Outfit");
        public static Armour MediumStellarBoundOutfit = new Armour(ArmourTypes.MediumOutfit, new StatIncrease(0,   0,   0,   240, 0,   0,   240, 0,   0,   0), "Medium Stellar-bound Outfit");
        public static List<Armour> MediumOutfits = new List<Armour> { MediumLeatherBoundOutfit, MediumIronBoundOutfit, MediumSteelBoundOutfit, MediumMythrilBoundOutfit, MediumJadeBoundOutfit, MediumCrystalBoundOutfit, MediumAdamantBoundOutfit, MediumStellarBoundOutfit };

                                                                                                       /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour LightLeatherWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Light Leather-woven Robes");
        public static Armour LightIronWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Light Iron-woven Robes");
        public static Armour LightSteelWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Light Steel-woven Robes");
        public static Armour LightMythrilWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Light Mythril-woven Robes");
        public static Armour LightJadeWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Light Jade-woven Robes");
        public static Armour LightCrystalWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(0,   0,   0,   180, 0,   0,   180, 0,   0,   0), "Light Crystal-woven Robes");
        public static Armour LightAdamantWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(0,   0,   0,   210, 0,   0,   210, 0,   0,   0), "Light Adamant-woven Robes");
        public static Armour LightStellarWovenRobes = new Armour(ArmourTypes.LightRobes, new StatIncrease(0,   0,   0,   240, 0,   0,   240, 0,   0,   0), "Light Stellar-woven Robes");
        public static List<Armour> LightRobes = new List<Armour> { LightLeatherWovenRobes, LightIronWovenRobes, LightSteelWovenRobes, LightMythrilWovenRobes, LightJadeWovenRobes, LightCrystalWovenRobes, LightAdamantWovenRobes, LightStellarWovenRobes };

                                                                                                       /* HP   MP   PA   PD   BM   WM   MD   HR   SP   CH */
        public static Armour HeavyLeatherWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(0,   0,   0,   30,  0,   0,   30,  0,   0,   0), "Heavy Leather-woven Robes");
        public static Armour HeavyIronWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(   0,   0,   0,   60,  0,   0,   60,  0,   0,   0), "Heavy Iron-woven Robes");
        public static Armour HeavySteelWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(  0,   0,   0,   90,  0,   0,   90,  0,   0,   0), "Heavy Steel-woven Robes");
        public static Armour HeavyMythrilWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(0,   0,   0,   120, 0,   0,   120, 0,   0,   0), "Heavy Mythril-woven Robes");
        public static Armour HeavyJadeWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(   0,   0,   0,   150, 0,   0,   150, 0,   0,   0), "Heavy Jade-woven Robes");
        public static Armour HeavyCrystalWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(0,   0,   0,   180, 0,   0,   180, 0,   0,   0), "Heavy Crystal-woven Robes");
        public static Armour HeavyAdamantWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(0,   0,   0,   210, 0,   0,   210, 0,   0,   0), "Heavy Adamant-woven Robes");
        public static Armour HeavyStellarWovenRobes = new Armour(ArmourTypes.HeavyRobes, new StatIncrease(0,   0,   0,   240, 0,   0,   240, 0,   0,   0), "Heavy Stellar-woven Robes");
        public static List<Armour> HeavyRobes = new List<Armour> { HeavyLeatherWovenRobes, HeavyIronWovenRobes, HeavySteelWovenRobes, HeavyMythrilWovenRobes, HeavyJadeWovenRobes, HeavyCrystalWovenRobes, HeavyAdamantWovenRobes, HeavyStellarWovenRobes };

        public static Armour MonkGi = new Armour(ArmourTypes.Gi, new StatIncrease(                        0,   0,   0,   0,   0,   0,   0,   0,   0,   0), "Monk Gi");
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
