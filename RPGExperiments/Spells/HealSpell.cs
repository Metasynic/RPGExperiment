using System;
using System.Collections.Generic;
using RPGExperiments.Entities;

namespace RPGExperiments.Spells
{
    public static class TestHealSpells
    {
        // White healing spells
        public static readonly HealSpell LightCure = new HealSpell("Light Cure", Target.EitherAlly, false, 1.0, 30);
        public static readonly HealSpell MediumCure = new HealSpell("Medium Cure", Target.EitherAlly, false, 2.25, 70);
        public static readonly HealSpell HeavyCure = new HealSpell("Heavy Cure", Target.EitherAlly, false, 3.75, 120);
        public static readonly HealSpell UltimateCure = new HealSpell("Ultimate Cure", Target.EitherAlly, false, 5.75, 180);

        public static readonly HealSpell Fairy = new HealSpell("Fairy", Target.AllAlly, false, 2.5, 95);
        public static readonly HealSpell Phoenix = new HealSpell("Phoenix", Target.AllAlly, false, 5.0, 185);
        // TODO: Fairy should remove all negative status effects
        // TODO: Phoenix should resurrect fallen teammates to full health
    }

    public class HealSpell : BaseSpell
    {
        private double power;
        public double Power { get => power; }

        public HealSpell(string name_, Target target_, bool black_, double power_, ushort cost_) : base(name_, target_, black_, cost_)
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
