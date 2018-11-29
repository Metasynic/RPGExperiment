using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExperiments
{
    public static class TestEntities
    {
        static byte levelBase = 50;                                                              /* STR VIT AGL INT SPR RES LCK CHR */
        public static BattleEntity Kazuma = new BattleEntity("Kazuma", (byte)(levelBase + 4),       6,  7,  13, 9,  4,  9,  14, 6,  TestWeapons.MythrilShortsword, TestArmour.ThiefCape);
        public static BattleEntity Aqua = new BattleEntity("Aqua", (byte)(levelBase + 4),           7,  8,  6,  4,  16, 13, 1,  14, TestWeapons.StaffOfRoses, TestArmour.GoddessSuit);
        public static BattleEntity Megumin = new BattleEntity("Megumin", (byte)(levelBase + 5),     4,  3,  9,  14, 6,  10, 11, 11, TestWeapons.CrimsonWoodRod, TestArmour.CrimsonHat);
        public static BattleEntity Darkness = new BattleEntity("Darkness", (byte)(levelBase + 5),   13, 14, 2,  5,  9,  11, 5,  8,  TestWeapons.SteelBroadsword, TestArmour.CrusaderHeavy);

        public static BattleEntity Wiz = new BattleEntity("Wiz", (byte)(levelBase + 8),             10, 10, 5,  6,  12, 7,  9,  7,  TestWeapons.CrystalDagger, TestArmour.PurpleRobes);
        public static BattleEntity Yunyun = new BattleEntity("Yunyun", (byte)(levelBase + 2),       9,  7,  6,  14, 8,  10, 5,  7,  TestWeapons.CrimsonWand, TestArmour.CrimsonUniform);
        public static BattleEntity Chris = new BattleEntity("Chris", (byte)(levelBase + 2),         6,  5,  14, 9,  6,  5,  16, 9,  TestWeapons.KnifeOfSilence, TestArmour.ThiefSuit);
        
        public static BattleEntity Sam = new BattleEntity("Sam", (byte)(levelBase + 1),             7,  6,  9,  12, 10, 11, 6,  7,  TestWeapons.AzureSword, TestArmour.AzureCloak);
        public static BattleEntity Lewis = new BattleEntity("Lewis", (byte)(levelBase + 1),         9,  7,  7,  10, 12, 10, 4,  9,  TestWeapons.RedSword, TestArmour.SteelLight);
        public static BattleEntity Freddie = new BattleEntity("Freddie", (byte)(levelBase + 1),     9,  11, 8,  5,  6,  10, 12, 7,  TestWeapons.DoubleBass, TestArmour.NiceSuit);
        public static BattleEntity James = new BattleEntity("James", (byte)(levelBase + 1),         6,  8,  11, 7,  12, 9,  6,  9,  TestWeapons.IronStaff, TestArmour.WhiteRobes);

        public static List<BattleEntity> Entities = new List<BattleEntity>() { Kazuma, Aqua, Megumin, Darkness, Wiz, Yunyun, Chris, Sam, Lewis, Freddie, James };
    }

    public class BattleEntity
    {
        /* Level goes from 1 to 99, naturally. */
        private byte level;
        public byte Level { get => level; }

        private string name;
        public string Name { get => name; }

        private Weapon weapon;
        public Weapon Weapon { get => weapon; }

        private ArmourPiece armour;
        public ArmourPiece Armour { get => armour; }

        private Dictionary<Spell, byte> spells;
        public Dictionary<Spell, byte> Spells { get => spells; }

        /* Base stats vary from 1 to 16 for simplicity.
         * 1-2: Abysmal.
         * 3-4: Really bad.
         * 5-6: Weak points.
         * 7-8: Not great.
         * 9-10: Decent.
         * 11-12: Pretty good.
         * 13-14: Very talented.
         * 15-16: Godlike. */
        private byte baseStr;
        private byte baseVit;
        private byte baseAgl;
        private byte baseInt;
        private byte baseSpt;
        private byte baseRes;
        private byte baseLck;
        private byte baseChr;

        public byte BaseStr { get => baseStr; }
        public byte BaseVit { get => baseVit; }
        public byte BaseAgl { get => baseAgl; }
        public byte BaseInt { get => baseInt; }
        public byte BaseSpt { get => baseSpt; }
        public byte BaseRes { get => baseRes; }
        public byte BaseLck { get => baseLck; }
        public byte BaseChr { get => baseChr; }

        public byte BaseStatTotal { get => (byte)(baseStr + baseVit + baseAgl + baseInt + baseSpt + baseRes + baseLck + baseChr); }

        public ushort MaxHealth { get => (ushort)Utils.Clamp((12 + baseVit) * level * 6 + baseLck * Math.Log(level), 1, 9999); }
        public ushort MaxMana { get => (ushort)Utils.Clamp(((baseInt + baseSpt + baseRes) * 2 / 3) * level / 1.5 + baseLck * Math.Log(level), 1, 999); }
        public ushort PhysAtk { get => (ushort)Utils.Clamp((level * (baseStr + 8)) / 2 + (level * weapon.WType.pow * weapon.Power / 4), 1, 999); }
        public ushort PhysDef { get => (ushort)Utils.Clamp((level * (baseVit + 8)) / 2 + (level * armour.Protection / 4), 1, 999); }
        public ushort BlackMag { get => (ushort)Utils.Clamp((level * (baseInt * 1.5 + baseChr / 2) / 1.5), 1, 999); }
        public ushort WhiteMag { get => (ushort)Utils.Clamp((level * (baseSpt * 1.5 + baseChr / 2) / 1.5), 1, 999); }
        public ushort MagDef { get => (ushort)Utils.Clamp((level * ((baseRes * 1.5) + (baseInt + baseSpt) / 4) / 1.5), 1, 999); }
        public byte HitRate { get => (byte)Utils.Clamp(1.5 * Math.Sqrt((Math.Log(level) + 1) * (8 + baseAgl + baseLck) * 125), 1, 255); }
        public byte Speed { get => (byte)Utils.Clamp(1.5 * Math.Sqrt((Math.Log(level) + 1) * (baseAgl + 8) * 200 + 2 * baseStr), 1, 255); }
        public byte Charm { get => (byte)Utils.Clamp(1.5 * Math.Sqrt(((Math.Log(level) + 1) * (baseChr + 8)) * 200 + baseLck), 1, 255); }

        public ushort PhysicalAttackDamage(BattleEntity defender, Random r)
        {
            ushort damage = (ushort)Utils.Clamp(PhysAtk * 3 - defender.PhysDef + r.Next(1, (ushort)(3 + Math.Log(level) * baseLck)), 1, 9999);

            if (r.NextDouble() < weapon.WType.crit)
            {
                Console.WriteLine("Critical!");
                return (ushort)(damage * 2);
            }
            else if (r.Next((int)(defender.Speed)) > HitRate * weapon.WType.hit)
            {
                Console.WriteLine("Glancing...");
                return (ushort)(damage / 2);
            }
            else
                return damage;
        }

        public ushort SpellAttackDamage(BattleEntity defender, Random r, AttackSpell spell, byte level)
        {
            ushort mag;
            if (spell.Black)
                mag = BlackMag;
            else
                mag = WhiteMag;

            ushort rawDamage = (ushort)(mag * (spell.Power + (level / 8) * spell.Power) / 1.5 - defender.MagDef + r.Next(1, (ushort)(3 + Math.Log(this.level) * baseLck)));
            if (spell.BreakDamageLimit)
                return rawDamage;
            else
                return (ushort)Utils.Clamp(rawDamage, 1, 9999);
        }

        public ushort SpellHealAmount(BattleEntity patient, Random r, HealSpell spell, byte level)
        {
            ushort mag;
            if (spell.Black)
                mag = BlackMag;
            else
                mag = WhiteMag;

            ushort rawHeal = (ushort)(mag * (spell.Power + (level / 8) * spell.Power) + r.Next(1, (ushort)(3 + Math.Log(this.level) * baseLck)));

            return (ushort)Utils.Clamp(rawHeal, 1, 9999);
        }

        public BattleEntity(string name_, byte level_, byte str_, byte vit_, byte agl_, byte int_, byte spt_, byte res_, byte lck_, byte chr_, Weapon weapon_, ArmourPiece armour_)
        {
            level = level_;
            name = name_;
            baseStr = str_;
            baseVit = vit_;
            baseAgl = agl_;
            baseInt = int_;
            baseSpt = spt_;
            baseRes = res_;
            baseLck = lck_;
            baseChr = chr_;
            weapon = weapon_;
            armour = armour_;
            spells = new Dictionary<Spell, byte>();
        }

        public void AddSpell(Spell spell, byte level)
        {
            spells.Add(spell, level);
        }

        public void AddSpells(ICollection<Spell> spellsCollection, byte level) {
            foreach (Spell spell in spellsCollection) {
                spells.Add(spell, level);
            }
        }

    }
}
