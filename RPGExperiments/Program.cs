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
            Console.WriteLine(b.Name.PadRight(9) + " Lv: " + b.Level + " BST: " + b.BaseStatTotal + " HP: " + b.MaxHealth + " MP: " + b.MaxMana + " Atk: " + b.PhysAtk + " Def: " + b.PhysDef + " BMag: " + b.BlackMag + " WMag: " + b.WhiteMag + " MDef: " + b.MagDef + " Hit: " + b.HitRate + " Spd: " + b.Speed + " Crm: " + b.Charm + " Crit: " + Math.Round(b.CritRate * 100, 1) + "%");
        }

        static void printPhysicalAttack(BaseEntity attacker, BaseEntity defender, Random r)
        {
            DamageInfo damageInfo = attacker.PhysicalAttackDamage(defender, r);
            if (damageInfo.Critical)
                Console.WriteLine("Critical Hit:");
            else if (damageInfo.Glancing)
                Console.WriteLine("Glancing Blow:");
            Console.WriteLine(attacker.Name + " does " + damageInfo.Damage + " damage to " + defender.Name + ".");
        }

        static void printSpell(BaseEntity attacker, BaseEntity defender, Random r) {
            BaseSpell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " for " + attacker.CastSpell(spell, defender, r));
        }

        static void Main(string[] args)
        {
            byte spellLevel = 8;
            TestEntities.Aqua.AddSpells(TestEntities.Aqua.CharacterClass.AllowedSpells, spellLevel);
            TestEntities.Megumin.AddSpell(TestSpells.Explosion, spellLevel);
            TestEntities.Yunyun.AddSpells(TestEntities.Yunyun.CharacterClass.AllowedSpells, spellLevel);
            TestEntities.Sam.AddSpells(TestEntities.Sam.CharacterClass.AllowedSpells, spellLevel);
            TestEntities.Lewis.AddSpells(TestEntities.Lewis.CharacterClass.AllowedSpells, spellLevel);

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
