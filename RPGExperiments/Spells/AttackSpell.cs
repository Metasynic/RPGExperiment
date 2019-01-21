using System;
namespace RPGExperiments.Spells
{
    public class AttackSpell : BaseSpell
    {
        private Element element;
        public Element Element { get => element; }

        private double power;
        public double Power { get => power; }

        private bool breakDamageLimit;
        public bool BreakDamageLimit { get => breakDamageLimit; }

        public AttackSpell(string name_, Target target_, bool black_, Element element_, double power_, ushort cost_, bool blue_ = false, bool breakDamageLimit_ = false) : base(name_, target_, black_, blue_, cost_)
        {
            element = element_;
            power = power_;
            breakDamageLimit = breakDamageLimit_;
        }
    }

}
