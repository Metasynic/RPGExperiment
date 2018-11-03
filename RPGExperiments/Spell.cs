using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments
{
    public enum Element { None, Earth, Air, Fire, Water, Lightning, Ice, Nature, Light, Dark }
    public enum Target { Single, EitherEnemy, Multi, Ally, Party, EitherAlly, None }

    public static class TestSpells
    {
        // Stand-alone specialist spells
        public static readonly AttackSpell Explosion = new AttackSpell("Explosion", Target.Multi, true, Element.None, 6.0, 200);
        public static readonly AttackSpell Lumina = new AttackSpell("Lumina", Target.EitherEnemy, false, Element.Light, 5.8, 185);
        public static readonly AttackSpell Eclipse = new AttackSpell("Eclipse", Target.EitherEnemy, true, Element.Dark, 5.8, 185);

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
        public static readonly AttackSpell Blizzard = new AttackSpell("Blizzard", Target.EitherEnemy, true,Element.Ice, 3.75, 120);
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

        // White healing spells
        public static readonly HealSpell LightCure = new HealSpell("Light Cure", Target.EitherAlly, false, 1.0, 30);
        public static readonly HealSpell MediumCure = new HealSpell("Medium Cure", Target.EitherAlly, false, 2.25, 70);
        public static readonly HealSpell HeavyCure = new HealSpell("Heavy Cure", Target.EitherAlly, false, 3.75, 120);
        public static readonly HealSpell UltimateCure = new HealSpell("Ultimate Cure", Target.EitherAlly, false, 5.75, 180);

        // Single-target blue magic attacks
        public static readonly AttackSpell Torch = new AttackSpell("Torch", Target.Single, true, Element.Fire, 1.1, 32, true);
        public static readonly AttackSpell Radiance = new AttackSpell("Radiance", Target.Single, true, Element.Light, 2.5, 75, true);
        public static readonly AttackSpell Blossom = new AttackSpell("Blossom", Target.Single, true, Element.Nature, 4.3, 130, true);
        public static readonly AttackSpell Geode = new AttackSpell("Geode", Target.Single, true, Element.Earth, 5.9, 185, true);
        public static readonly AttackSpell ShadowCore = new AttackSpell("Shadow Core", Target.Single, true, Element.Dark, 7.5, 210, true);

        // Multi-target blue magic attacks
        public static readonly AttackSpell Waterfall = new AttackSpell("Waterfall", Target.Multi, true, Element.Water, 1.75, 68, true);
        public static readonly AttackSpell ChargeField = new AttackSpell("Charge Field", Target.Multi, true, Element.Lightning, 3.0, 90, true);
        public static readonly AttackSpell FuryWind = new AttackSpell("Fury Wind", Target.Multi, true, Element.Air, 3.6, 115, true);
        public static readonly AttackSpell Glacier = new AttackSpell("Glacier", Target.Multi, true, Element.Ice, 4.75, 140, true);
        public static readonly AttackSpell ChaosFold = new AttackSpell("Chaos Fold", Target.Multi, true, Element.None, 5.5, 190, true);

        // The cosmic magics, ridiculously powerful and capable of breaking the damage limit
        public static readonly AttackSpell Comet = new AttackSpell("Comet", Target.Multi, true, Element.None, 3.75, 100, false, true);
        public static readonly AttackSpell Meteor = new AttackSpell("Meteor", Target.Multi, true, Element.None, 5.75, 150, false, true);
        public static readonly AttackSpell Starfall = new AttackSpell("Starfall", Target.Multi, true, Element.None, 8.0, 200, false, true);
        public static readonly AttackSpell Nova = new AttackSpell("Nova", Target.Multi, true, Element.None, 16.0, 500, false, true);

        // Spell lists
        public static readonly List<AttackSpell> Specialist = new List<AttackSpell> { Explosion, Lumina, Eclipse };
        public static readonly List<AttackSpell> BasicElem = new List<AttackSpell> { Frost, Flame, Gust, Bolt, Wave, Rockfall, Sprout };
        public static readonly List<AttackSpell> IntElem = new List<AttackSpell> { Hail, Blaze, Gale, Discharge, Downpour, Boulder, Growth };
        public static readonly List<AttackSpell> AdvElem = new List<AttackSpell> { Blizzard, Inferno, Tornado, Surge, Flood, Landslide, Emergence };
        public static readonly List<AttackSpell> UltElem = new List<AttackSpell> { Avalanche, Flare, Hurricane, Storm, Tsunami, Earthquake, Awakening };
        public static readonly List<HealSpell> WhiteHeal = new List<HealSpell> { LightCure, MediumCure, HeavyCure, UltimateCure };
        public static readonly List<AttackSpell> SingleElemBlue = new List<AttackSpell> { Torch, Radiance, Blossom, Geode, ShadowCore };
        public static readonly List<AttackSpell> MultiElemBlue = new List<AttackSpell> { Waterfall, ChargeField, FuryWind, Glacier, ChaosFold };
        public static readonly List<AttackSpell> Cosmic = new List<AttackSpell> { Comet, Meteor, Starfall, Nova };
    }

    public class Spell
    {
        protected string name;
        public string Name { get => name; }

        protected Target target;
        public Target Target { get => target; }

        protected bool black;
        public bool Black { get => black; }

        protected bool blue;
        public bool Blue { get => blue; }

        private ushort cost;
        public ushort Cost { get => cost; }

        public Spell(string name_, Target target_, bool black_, bool blue_, ushort cost_)
        {
            name = name_;
            target = target_;
            black = black_;
            blue = blue_;
            cost = cost_;
        }
    }

    public class AttackSpell : Spell
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

    public class HealSpell : Spell
    {
        private double power;
        public double Power { get => power; }

        public HealSpell(string name_, Target target_, bool black_, double power_, ushort cost_, bool blue_ = false) : base(name_, target_, black_, blue_, cost_)
        {
            power = power_;
        }
    }
}
