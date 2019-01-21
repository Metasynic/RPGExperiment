using System;
using System.Linq;
using RPGExperiments.Entities;
using RPGExperiments.Spells;

namespace RPGExperiments
{
    public class Program
    {
        static void printCharacter(BaseEntity b)
        {
            Console.WriteLine(b.Name.PadRight(9) + " Lv: " + b.Level + " BST: " + b.BaseStatTotal + " HP: " + b.MaxHealth + " MP: " + b.MaxMana + " Atk: " + b.PhysAtk + " Def: " + b.PhysDef + " BMag: " + b.BlackMag + " WMag: " + b.WhiteMag + " MDef: " + b.MagDef + " Hit: " + b.HitRate + " Spd: " + b.Speed + " Crm: " + b.Charm);
        }

        static void printPhysicalAttack(BaseEntity attacker, BaseEntity defender, Random r)
        {
            Console.WriteLine(attacker.Name + " does " + attacker.PhysicalAttackDamage(defender, r) + " damage to " + defender.Name + ".");
        }

        static void printSpell(BaseEntity attacker, BaseEntity defender, Random r) {
            BaseSpell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            byte level = attacker.Spells[spell];
            if (spell.GetType() == typeof(AttackSpell)) {
                Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " for " + attacker.SpellAttackDamage(defender, r, (AttackSpell)spell, level));
            }
            else if (spell.GetType() == typeof(HealSpell)) {
                Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " healing " + attacker.SpellHealAmount(defender, r, (HealSpell)spell, level));
            }
        }

        static void Main(string[] args)
        {
            byte spellLevel = 8;
            TestEntities.Aqua.AddSpells(TestSpells.WhiteMageSet, spellLevel);
            TestEntities.Megumin.AddSpell(TestSpells.Explosion, spellLevel);
            TestEntities.Yunyun.AddSpells(TestSpells.BlackMageSet, spellLevel);
            TestEntities.Sam.AddSpells(TestSpells.BlueMageSet, spellLevel);
            TestEntities.Lewis.AddSpells(TestSpells.RedMageSet, spellLevel);

            foreach (BaseEntity entity in TestEntities.Entities)
            {
                printCharacter(entity);
            }

            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                printPhysicalAttack(TestEntities.Entities[r.Next(0, TestEntities.Entities.Count)], TestEntities.Entities[r.Next(0, TestEntities.Entities.Count)], r);
            }

            printSpell(TestEntities.Aqua, TestEntities.Chris, r);
            printSpell(TestEntities.Megumin, TestEntities.Kazuma, r);
            printSpell(TestEntities.Sam, TestEntities.Darkness, r);
            printSpell(TestEntities.Yunyun, TestEntities.Wiz, r);
            printSpell(TestEntities.Lewis, TestEntities.Sam, r);

            Console.ReadKey();
        }
    }
}
