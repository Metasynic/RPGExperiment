using System;
using RPGExperiments.Entities;

namespace RPGExperiments.Spells
{
    public static class TestAttackSpells
    {
        // Stand-alone specialist spells
        public static readonly AttackSpell Explosion = new AttackSpell("Explosion", Target.AllEnemy, true, Element.None, 6.0, 200);
        public static readonly AttackSpell Blast = new AttackSpell("Blast", Target.AllEnemy, true, Element.None, 3.5, 110);
        public static readonly AttackSpell Lumina = new AttackSpell("Lumina", Target.EitherEnemy, false, Element.Light, 5.8, 185);
        public static readonly AttackSpell Eclipse = new AttackSpell("Eclipse", Target.EitherEnemy, true, Element.Dark, 5.8, 185);
        public static readonly AttackSpell Aura = new AttackSpell("Aura", Target.EitherEnemy, false, Element.Light, 2.5, 80);
        public static readonly AttackSpell Shadow = new AttackSpell("Shadow", Target.EitherEnemy, true, Element.Dark, 2.5, 80);

        // Basic elemental spells
        public static readonly AttackSpell Frost = new AttackSpell("Frost", Target.EitherEnemy, true, Element.Ice, 1.0, 30);
        public static readonly AttackSpell Flame = new AttackSpell("Flame", Target.EitherEnemy, true, Element.Fire, 1.0, 30);
        public static readonly AttackSpell Gust = new AttackSpell("Gust", Target.EitherEnemy, true, Element.Air, 1.0, 30);
        public static readonly AttackSpell Bolt = new AttackSpell("Bolt", Target.EitherEnemy, true, Element.Lightning, 1.0, 30);
        public static readonly AttackSpell Wave = new AttackSpell("Wave", Target.EitherEnemy, true, Element.Water, 1.0, 30);
        public static readonly AttackSpell Rockfall = new AttackSpell("Rockfall", Target.EitherEnemy, true, Element.Earth, 1.0, 30);
        public static readonly AttackSpell Sprout = new AttackSpell("Sprout", Target.EitherEnemy, true, Element.Nature, 1.0, 30);

        // Intermediate elemental spells
        public static readonly AttackSpell Hail = new AttackSpell("Hail", Target.EitherEnemy, true, Element.Ice, 2.25, 70);
        public static readonly AttackSpell Blaze = new AttackSpell("Blaze", Target.EitherEnemy, true, Element.Fire, 2.25, 70);
        public static readonly AttackSpell Gale = new AttackSpell("Gale", Target.EitherEnemy, true, Element.Air, 2.25, 70);
        public static readonly AttackSpell Discharge = new AttackSpell("Discharge", Target.EitherEnemy, true, Element.Lightning, 2.25, 70);
        public static readonly AttackSpell Downpour = new AttackSpell("Downpour", Target.EitherEnemy, true, Element.Water, 2.25, 70);
        public static readonly AttackSpell Boulder = new AttackSpell("Boulder", Target.EitherEnemy, true, Element.Earth, 2.25, 70);
        public static readonly AttackSpell Growth = new AttackSpell("Growth", Target.EitherEnemy, true, Element.Nature, 2.25, 70);

        // Advanced elemental spells
        public static readonly AttackSpell Blizzard = new AttackSpell("Blizzard", Target.EitherEnemy, true, Element.Ice, 3.75, 120);
        public static readonly AttackSpell Inferno = new AttackSpell("Inferno", Target.EitherEnemy, true, Element.Fire, 3.75, 120);
        public static readonly AttackSpell Tornado = new AttackSpell("Tornado", Target.EitherEnemy, true, Element.Air, 3.75, 120);
        public static readonly AttackSpell Surge = new AttackSpell("Surge", Target.EitherEnemy, true, Element.Lightning, 3.75, 120);
        public static readonly AttackSpell Flood = new AttackSpell("Flood", Target.EitherEnemy, true, Element.Water, 3.75, 120);
        public static readonly AttackSpell Landslide = new AttackSpell("Landslide", Target.EitherEnemy, true, Element.Earth, 3.75, 120);
        public static readonly AttackSpell Emergence = new AttackSpell("Emergence", Target.EitherEnemy, true, Element.Nature, 3.75, 120);

        // Ultimate elemental spells
        public static readonly AttackSpell Avalanche = new AttackSpell("Avalanche", Target.EitherEnemy, true, Element.Ice, 5.75, 180);
        public static readonly AttackSpell Flare = new AttackSpell("Flare", Target.EitherEnemy, true, Element.Fire, 5.75, 180);
        public static readonly AttackSpell Hurricane = new AttackSpell("Hurricane", Target.EitherEnemy, true, Element.Air, 5.75, 180);
        public static readonly AttackSpell Storm = new AttackSpell("Storm", Target.EitherEnemy, true, Element.Lightning, 5.75, 180);
        public static readonly AttackSpell Tsunami = new AttackSpell("Tsunami", Target.EitherEnemy, true, Element.Water, 5.75, 180);
        public static readonly AttackSpell Earthquake = new AttackSpell("Earthquake", Target.EitherEnemy, true, Element.Earth, 5.75, 180);
        public static readonly AttackSpell Awakening = new AttackSpell("Awakening", Target.EitherEnemy, true, Element.Nature, 5.75, 180);

        // Single-target blue magic attacks
        public static readonly AttackSpell Torch = new AttackSpell("Torch", Target.SingleEnemy, true, Element.Fire, 1.1, 32);
        public static readonly AttackSpell Radiance = new AttackSpell("Radiance", Target.SingleEnemy, true, Element.Light, 2.5, 75);
        public static readonly AttackSpell Blossom = new AttackSpell("Blossom", Target.SingleEnemy, true, Element.Nature, 4.3, 130);
        public static readonly AttackSpell Geode = new AttackSpell("Geode", Target.SingleEnemy, true, Element.Earth, 5.9, 185);
        public static readonly AttackSpell ShadowCore = new AttackSpell("Shadow Core", Target.SingleEnemy, true, Element.Dark, 7.0, 210);

        // Multi-target blue magic attacks
        public static readonly AttackSpell Waterfall = new AttackSpell("Waterfall", Target.AllEnemy, true, Element.Water, 1.75, 68);
        public static readonly AttackSpell ChargeField = new AttackSpell("Charge Field", Target.AllEnemy, true, Element.Lightning, 3.0, 90);
        public static readonly AttackSpell FuryWind = new AttackSpell("Fury Wind", Target.AllEnemy, true, Element.Air, 3.6, 115);
        public static readonly AttackSpell Glacier = new AttackSpell("Glacier", Target.AllEnemy, true, Element.Ice, 4.75, 150);
        public static readonly AttackSpell ChaosFold = new AttackSpell("Chaos Fold", Target.AllEnemy, true, Element.None, 5.5, 190);

        // The cosmic magics, ridiculously powerful and capable of breaking the damage limit
        public static readonly AttackSpell Comet = new AttackSpell("Comet", Target.AllEnemy, true, Element.None, 3.75, 100, true);
        public static readonly AttackSpell Meteor = new AttackSpell("Meteor", Target.AllEnemy, true, Element.None, 5.75, 150, true);
        public static readonly AttackSpell Starfall = new AttackSpell("Starfall", Target.AllEnemy, true, Element.None, 8.0, 200, true);
        public static readonly AttackSpell Nova = new AttackSpell("Nova", Target.AllEnemy, true, Element.None, 16.0, 500, true);

        // Attacking summons
        public static readonly AttackSpell Wolf = new AttackSpell("Wolf", Target.AllEnemy, true, Element.None, 1.0, 40);
        public static readonly AttackSpell Golem = new AttackSpell("Golem", Target.AllEnemy, true, Element.Earth, 1.6, 60);
        public static readonly AttackSpell Yeti = new AttackSpell("Yeti", Target.AllEnemy, true, Element.Ice, 2.2, 80);
        public static readonly AttackSpell Valkyrie = new AttackSpell("Valkyrie", Target.AllEnemy, true, Element.Lightning, 2.8, 100);
        public static readonly AttackSpell Dryad = new AttackSpell("Dryad", Target.AllEnemy, true, Element.Nature, 3.4, 120);
        public static readonly AttackSpell Unicorn = new AttackSpell("Unicorn", Target.AllEnemy, true, Element.Air, 4.0, 140);
        public static readonly AttackSpell Hydra = new AttackSpell("Hydra", Target.AllEnemy, true, Element.Water, 4.6, 160);
        public static readonly AttackSpell Cerberus = new AttackSpell("Cerberus", Target.AllEnemy, true, Element.None, 5.4, 190);
        public static readonly AttackSpell Dragon = new AttackSpell("Dragon", Target.AllEnemy, true, Element.Fire, 6.0, 220);
    }

    public class AttackSpell : BaseSpell
    {
        private Element element;
        public Element Element { get => element; }

        private double power;
        public double Power { get => power; }

        private bool breakDamageLimit;
        public bool BreakDamageLimit { get => breakDamageLimit; }

        public AttackSpell(string name_, Target target_, bool black_, Element element_, double power_, ushort cost_, bool breakDamageLimit_ = false) : base(name_, target_, black_, cost_)
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
