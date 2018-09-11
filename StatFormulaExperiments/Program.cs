using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatFormulaExperiments
{
    public class Program
    {
        static void printCharacter(BattleEntity b)
        {
            Console.WriteLine(b.Name.PadRight(9) + " Lv: " + b.Level + " BST: " + b.BaseStatTotal + " HP: " + b.MaxHealth + " MP: " + b.MaxMana + " Atk: " + b.PhysAtk + " Def: " + b.PhysDef + " BMag: " + b.BlackMag + " WMag: " + b.WhiteMag + " MDef: " + b.MagDef + " Hit: " + b.HitRate + " Spd: " + b.Speed + " Crm: " + b.Charm);
        }

        static void printPhysicalAttack(BattleEntity attacker, BattleEntity defender, Random r)
        {
            Console.WriteLine(attacker.Name + " does " + attacker.PhysicalAttackDamage(defender, r) + " damage to " + defender.Name + ".");
        }

        static void printAttackSpell(BattleEntity attacker, BattleEntity defender, Random r) {
            Spell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            byte level = attacker.Spells[spell];
            Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " for " + attacker.SpellAttackDamage(defender, r, (AttackSpell)spell, level));
        }

        static void printHealSpell(BattleEntity attacker, BattleEntity defender, Random r)
        {
            Spell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            byte level = attacker.Spells[spell];
            Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " healing " + attacker.SpellHealAmount(defender, r, (HealSpell)spell, level));
        }

        static void Main(string[] args)
        {
            byte spellLevel = 8;
            TestEntities.Aqua.AddSpell(TestSpells.HeavyCure, spellLevel);
            TestEntities.Megumin.AddSpell(TestSpells.Ultima, spellLevel);
            TestEntities.Yunyun.AddSpell(TestSpells.Eclipse, spellLevel);
            TestEntities.Yunyun.AddSpell(TestSpells.Frost, spellLevel);
            TestEntities.Yunyun.AddSpell(TestSpells.Hail, spellLevel);
            TestEntities.Yunyun.AddSpell(TestSpells.Blizzard, spellLevel);
            TestEntities.Yunyun.AddSpell(TestSpells.Avalanche, spellLevel);
            TestEntities.Sam.AddSpell(TestSpells.ChargeField, spellLevel);
            TestEntities.Sam.AddSpell(TestSpells.ShadowCore, spellLevel);

            foreach (BattleEntity entity in TestEntities.Entities)
            {
                printCharacter(entity);
            }

            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                printPhysicalAttack(TestEntities.Entities[r.Next(0, TestEntities.Entities.Count)], TestEntities.Entities[r.Next(0, TestEntities.Entities.Count)], r);
            }

            printHealSpell(TestEntities.Aqua, TestEntities.Chris, r);
            printAttackSpell(TestEntities.Megumin, TestEntities.Kazuma, r);
            printAttackSpell(TestEntities.Sam, TestEntities.Darkness, r);
            printAttackSpell(TestEntities.Yunyun, TestEntities.Wiz, r);

            Console.ReadKey();
        }
    }
}
