using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatFormulaExperiments
{
    public enum Element { None, Earth, Air, Fire, Water, Lightning, Ice, Nature, Light, Dark }
    public enum Target { Single, Either, Multi, Ally, Party, None }

    public static class TestSpells
    {
        // Stand-alone specialist spells
        public static AttackSpell Ultima = new AttackSpell("Ultima", Target.Multi, true, Element.None, 6.0, 200);
        public static AttackSpell Lumina = new AttackSpell("Lumina", Target.Either, false, Element.Light, 5.8, 185);
        public static AttackSpell Eclipse = new AttackSpell("Eclipse", Target.Either, true, Element.Dark, 5.8, 185);

        // Basic elemental spells
        public static AttackSpell Frost = new AttackSpell("Frost", Target.Either, true, Element.Ice, 1.0, 30);
        public static AttackSpell Flame = new AttackSpell("Flame", Target.Either, true, Element.Fire, 1.0, 30);
        public static AttackSpell Gust = new AttackSpell("Gust", Target.Either, true, Element.Air, 1.0, 30);
        public static AttackSpell Bolt = new AttackSpell("Bolt", Target.Either, true, Element.Lightning, 1.0, 30);
        public static AttackSpell Wave = new AttackSpell("Wave", Target.Either, true, Element.Water, 1.0, 30);
        public static AttackSpell Rockfall = new AttackSpell("Rockfall", Target.Either, true, Element.Earth, 1.0, 30);
        public static AttackSpell Sprout = new AttackSpell("Sprout", Target.Either, true, Element.Nature, 1.0, 30);

        // Intermediate elemental spells
        public static AttackSpell Hail = new AttackSpell("Hail", Target.Either, true, Element.Ice, 2.25, 70);
        public static AttackSpell Blaze = new AttackSpell("Blaze", Target.Either, true, Element.Fire, 2.25, 70);
        public static AttackSpell Gale = new AttackSpell("Gale", Target.Either, true, Element.Air, 2.25, 70);
        public static AttackSpell Discharge = new AttackSpell("Discharge", Target.Either, true, Element.Lightning, 2.25, 70);
        public static AttackSpell Downpour = new AttackSpell("Downpour", Target.Either, true, Element.Water, 2.25, 70);
        public static AttackSpell Boulder = new AttackSpell("Boulder", Target.Either, true, Element.Earth, 2.25, 70);
        public static AttackSpell Growth = new AttackSpell("Growth", Target.Either, true, Element.Nature, 2.25, 70);

        // Advanced elemental spells
        public static AttackSpell Blizzard = new AttackSpell("Blizzard", Target.Either, true,Element.Ice, 3.75, 120);
        public static AttackSpell Inferno = new AttackSpell("Inferno", Target.Either, true, Element.Fire, 3.75, 120);
        public static AttackSpell Tornado = new AttackSpell("Tornado", Target.Either, true, Element.Air, 3.75, 120);
        public static AttackSpell Surge = new AttackSpell("Surge", Target.Either, true, Element.Lightning, 3.75, 120);
        public static AttackSpell Flood = new AttackSpell("Flood", Target.Either, true, Element.Water, 3.75, 120);
        public static AttackSpell Landslide = new AttackSpell("Landslide", Target.Either, true, Element.Earth, 3.75, 120);
        public static AttackSpell Emergence = new AttackSpell("Emergence", Target.Either, true, Element.Nature, 3.75, 120);

        // Ultimate elemental spells
        public static AttackSpell Avalanche = new AttackSpell("Avalanche", Target.Either, true, Element.Ice, 5.75, 180);
        public static AttackSpell Flare = new AttackSpell("Flare", Target.Either, true, Element.Fire, 5.75, 180);
        public static AttackSpell Hurricane = new AttackSpell("Hurricane", Target.Either, true, Element.Air, 5.75, 180);
        public static AttackSpell Storm = new AttackSpell("Storm", Target.Either, true, Element.Lightning, 5.75, 180);
        public static AttackSpell Tsunami = new AttackSpell("Tsunami", Target.Either, true, Element.Water, 5.75, 180);
        public static AttackSpell Earthquake = new AttackSpell("Earthquake", Target.Either, true, Element.Earth, 5.75, 180);
        public static AttackSpell Awakening = new AttackSpell("Awakening", Target.Either, true, Element.Nature, 5.75, 180);

        // White healing spells
        public static HealSpell LightCure = new HealSpell("Light Cure", Target.Either, false, 1.0, 30);
        public static HealSpell MediumCure = new HealSpell("Medium Cure", Target.Either, false, 2.25, 70);
        public static HealSpell HeavyCure = new HealSpell("Heavy Cure", Target.Either, false, 3.75, 120);
        public static HealSpell UltimateCure = new HealSpell("Ultimate Cure", Target.Either, false, 5.75, 180);

        // Single-target blue magic attacks
        public static AttackSpell Torch = new AttackSpell("Torch", Target.Single, true, Element.Fire, 1.15, 32, true);
        public static AttackSpell Radiance = new AttackSpell("Radiance", Target.Single, true, Element.Light, 2.5, 75, true);
        public static AttackSpell Blossom = new AttackSpell("Blossom", Target.Single, true, Element.Nature, 4.3, 130, true);
        public static AttackSpell Geode = new AttackSpell("Geode", Target.Single, true, Element.Earth, 5.9, 185, true);
        public static AttackSpell ShadowCore = new AttackSpell("Shadow Core", Target.Single, true, Element.Dark, 7.5, 210, true);

        // Multi-target blue magic attacks
        public static AttackSpell Waterfall = new AttackSpell("Waterfall", Target.Multi, true, Element.Water, 2.1, 68, true);
        public static AttackSpell ChargeField = new AttackSpell("Charge Field", Target.Multi, true, Element.Lightning, 3.0, 90, true);
        public static AttackSpell FuryWind = new AttackSpell("Fury Wind", Target.Multi, true, Element.Air, 3.6, 115, true);
        public static AttackSpell Glacier = new AttackSpell("Glacier", Target.Multi, true, Element.Ice, 4.75, 140, true);
        public static AttackSpell ChaosFold = new AttackSpell("Chaos Fold", Target.Multi, true, Element.None, 5.5, 190, true);

        // The cosmic magics, ridiculously powerful and capable of breaking the damage limit
        public static AttackSpell Comet = new AttackSpell("Comet", Target.Multi, true, Element.None, 3.75, 100, false, true);
        public static AttackSpell Meteor = new AttackSpell("Meteor", Target.Multi, true, Element.None, 5.75, 150, false, true);
        public static AttackSpell Starfall = new AttackSpell("Starfall", Target.Multi, true, Element.None, 8.0, 200, false, true);
        public static AttackSpell Nova = new AttackSpell("Nova", Target.Multi, true, Element.None, 16.0, 500, false, true);

        // Spell lists
        public static List<AttackSpell> Specialist = new List<AttackSpell> { Ultima, Lumina, Eclipse };
        public static List<AttackSpell> BasicElem = new List<AttackSpell> { Frost, Flame, Gust, Bolt, Wave, Rockfall, Sprout };
        public static List<AttackSpell> IntElem = new List<AttackSpell> { Hail, Blaze, Gale, Discharge, Downpour, Boulder, Growth };
        public static List<AttackSpell> AdvElem = new List<AttackSpell> { Blizzard, Inferno, Tornado, Surge, Flood, Landslide, Emergence };
        public static List<AttackSpell> UltElem = new List<AttackSpell> { Avalanche, Flare, Hurricane, Storm, Tsunami, Earthquake, Awakening };
        public static List<HealSpell> WhiteHeal = new List<HealSpell> { LightCure, MediumCure, HeavyCure, UltimateCure };
        public static List<AttackSpell> SingleElemBlue = new List<AttackSpell> { Torch, Radiance, Blossom, Geode, ShadowCore };
        public static List<AttackSpell> MultiElemBlue = new List<AttackSpell> { Waterfall, ChargeField, FuryWind, Glacier, ChaosFold };
        public static List<AttackSpell> Cosmic = new List<AttackSpell> { Comet, Meteor, Starfall, Nova };
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
