
namespace RPGExperiments.Spells
{
    public class HealSpell : BaseSpell
    {
        private double power;
        public double Power { get => power; }

        public HealSpell(string name_, Target target_, bool black_, double power_, ushort cost_, bool blue_ = false) : base(name_, target_, black_, blue_, cost_)
        {
            power = power_;
        }
    }
}
