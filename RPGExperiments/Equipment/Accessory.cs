using System;
namespace RPGExperiments.Equipment
{
    public static class TestAccessories
    {
        public static Accessory None = new Accessory(new StatIncrease(0, 0, 0, 0, 0, 0, 0, 0, 0, 0), "None");
    }

    public class Accessory : BaseEquipment
    {
        public Accessory(StatIncrease increase_, string name_) : base(increase_, name_)
        {

        }
    }
}
