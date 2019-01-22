using System;
using RPGExperiments.Entities;

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

        public ushort AttackDamage(BaseEntity attacker, BaseEntity defender, Random r, AttackSpell spell, byte spellLevel, byte baseLck)
        {
            ushort mag;
            if (spell.Black)
                mag = attacker.BlackMag;
            else
                mag = attacker.WhiteMag;

            ushort rawDamage = (ushort)(mag * (spell.Power + (spellLevel / 8) * spell.Power) - defender.MagDef + r.Next(1, (ushort)(3 + Math.Log(attacker.Level) * baseLck)));
            if (spell.BreakDamageLimit)
                return rawDamage;
            return (ushort)Utils.Clamp(rawDamage, 1, 9999);
        }
    }

}
