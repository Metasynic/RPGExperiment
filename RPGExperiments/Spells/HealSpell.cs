using System;
using RPGExperiments.Entities;

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

        public ushort HealAmount(BaseEntity caster, BaseEntity patient, Random r, HealSpell spell, byte spellLevel, byte baseLck)
        {
            ushort mag;
            if (spell.Black)
                mag = caster.BlackMag;
            else
                mag = caster.WhiteMag;

            ushort rawHeal = (ushort)(mag * (spell.Power + (spellLevel / 8) * spell.Power) + r.Next(1, (ushort)(3 + Math.Log(caster.Level) * baseLck)));

            return (ushort)Utils.Clamp(rawHeal, 1, 9999);
        }
    }
}
