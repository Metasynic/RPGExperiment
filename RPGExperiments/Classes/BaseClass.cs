using System.Collections.Generic;
using RPGExperiments.Equipment;
using RPGExperiments.Spells;
using static RPGExperiments.Spells.TestAttackSpells;
using static RPGExperiments.Spells.TestHealSpells;

namespace RPGExperiments.Classes
{
    public static class CharacterClasses
    {
        // The adventurer is a jack-of-all-trades, able to learn any non-class-exclusive technique or spell
        // but at a higher experience cost to learn and upgrade than the other classes.
        public static BaseClass Adventurer = new BaseClass("Adventurer",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ Explosion, Lumina, Eclipse, Aura, Shadow,
        Frost, Flame, Gust, Bolt, Wave, Rockfall, Sprout,
        Hail, Blaze, Gale, Discharge, Downpour, Boulder, Growth,
        Blizzard, Inferno, Tornado, Surge, Flood, Landslide, Emergence,
        Avalanche, Flare, Hurricane, Storm, Tsunami, Earthquake, Awakening,
        LightCure, MediumCure, HeavyCure, UltimateCure });

        // The white mage provides healing for a party and gives them stat buffs. They can also
        // cure status ailments and have a few light-elemental attack spells.
        public static BaseClass WhiteMage = new BaseClass("White Mage",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ Lumina, Aura,
            LightCure, MediumCure, HeavyCure, UltimateCure });

        // The black mage casts offensive spells, doing elemental damage and inflicting status effects.
        // They also have access to utility magic such as warping.
        public static BaseClass BlackMage = new BaseClass("Black Mage",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ Explosion, Eclipse, Shadow,
            Frost, Flame, Gust, Bolt, Wave, Rockfall, Sprout,
            Hail, Blaze, Gale, Discharge, Downpour, Boulder, Growth,
            Blizzard, Inferno, Tornado, Surge, Flood, Landslide, Emergence,
            Avalanche, Flare, Hurricane, Storm, Tsunami, Earthquake, Awakening });

        // The red mage is able to learn both offensive and healing spells, but not at a high level
        // and can use a more varied range of weaponry to compensate for lack of late-game magic.
        public static BaseClass RedMage = new BaseClass("Red Mage",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ Blast,
            Frost, Flame, Gust, Bolt, Wave, Rockfall, Sprout,
            Hail, Blaze, Gale, Discharge, Downpour, Boulder, Growth });

        // The blue mage can only learn spells cast on them by monsters, which often have strange
        // effects and gives eventual versatility but can't learn spells easily early on.
        public static BaseClass BlueMage = new BaseClass("Blue Mage",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ Torch, Radiance, Blossom, Geode, ShadowCore,
            Waterfall, ChargeField, FuryWind, Glacier, ChaosFold });

        // The summoner calls upon various mythical creatures to help them in battle.
        public static BaseClass Summoner = new BaseClass("Summoner",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell> { Wolf, Golem, Yeti, Fairy, Valkyrie, /* TODO: Basilisk attempts to petrify all enemies */ 
        Dryad, Unicorn, Hydra, Phoenix, Cerberus, /* TODO: Shade attempts to instakill all enemies */ Dragon });

        // The geomancer channels the power of their environment to inflict damage on their enemies.
        public static BaseClass Geomancer = new BaseClass("Geomancer",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());

        // Fighters use straight forward physical attacks to hit their enemies, placing an emphasis
        // on strength and speed to get lots of hits in.
        public static BaseClass Fighter = new BaseClass("Fighter",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());

        // Thieves have a variety of stealth options and ways to steal items from enemies, focusing
        // on speed to evade enemy attacks and with a few black magic spells.
        public static BaseClass Thief = new BaseClass("Thief",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());

        // Knights are defensive combatants with heavy armour who absorb hits and have a high vitality.
        public static BaseClass Knight = new BaseClass("Knight",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());

        // Paladins are holy soldiers who combine armour with some white magic to tend to others in battle.
        public static BaseClass Paladin = new BaseClass("Paladin",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>{ LightCure, MediumCure });

        // Rangers can use bows to attack from range, meaning they can attack from the back row like mages.
        public static BaseClass Ranger = new BaseClass("Ranger",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());

        // Monks use their bare fists to bash enemies and should not equip weapons.
        // Their attack power scales linearly with level as opposed to in jumps.
        public static BaseClass Monk = new BaseClass("Monk",
        new List<Weapon>(),
        new List<Armour>(),
        new List<Accessory>(),
        new List<BaseSpell>());
    }

    public class BaseClass
    {
        protected string name;
        public string Name { get => name; }

        protected List<Weapon> allowedWeapons;
        public List<Weapon> AllowedWeapons { get => allowedWeapons; }

        protected List<Armour> allowedArmour;
        public List<Armour> AllowedArmour { get => allowedArmour; }

        protected List<Accessory> allowedAccessories;
        public List<Accessory> AllowedAccessories { get => allowedAccessories; }

        protected List<BaseSpell> allowedSpells;
        public List<BaseSpell> AllowedSpells { get => allowedSpells; }

        public BaseClass(string name_, List<Weapon> allowedWeapons_, List<Armour> allowedArmour_, List<Accessory> allowedAccessories_, List<BaseSpell> allowedSpells_)
        {
            name = name_;
            allowedWeapons = allowedWeapons_;
            allowedArmour = allowedArmour_;
            allowedAccessories = allowedAccessories_;
            allowedSpells = allowedSpells_;
        }
    }
}
