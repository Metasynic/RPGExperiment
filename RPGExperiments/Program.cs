using System;
using System.Linq;
using RPGExperiments.Entities;
using RPGExperiments.Spells;

namespace RPGExperiments
{
    public class Program
    {
        static void printAttack(BaseEntity attacker, BaseEntity target, Random r)
        {
            if (attacker.Spells.Count != 0) {
                if (r.Next(3) == 0)
                {
                    printPhysicalAttack(attacker, target, r);
                }
                else
                {
                    printSpell(attacker, target, r);
                }
            }
            else
            {
                printPhysicalAttack(attacker, target, r);
            }
        }

        static void printCharacter(BaseEntity b)
        {
            Console.WriteLine(b.Name.PadRight(9) + " Lv: " + b.Level + " BST: " + (b as PlayerEntity).BaseStatTotal + " HP: " + b.MaxHealth + " MP: " + b.MaxMana + " Atk: " + b.PhysAtk + " Def: " + b.PhysDef + " BMag: " + b.BlackMag + " WMag: " + b.WhiteMag + " MDef: " + b.MagDef + " Hit: " + b.HitRate + " Spd: " + b.Speed + " Crm: " + b.Charm + " FST: " + (b.PhysAtk + b.PhysDef + b.BlackMag + b.WhiteMag + b.MagDef + b.HitRate + b.Speed + b.Charm) + " Crit: " + Math.Round(b.CritRate * 100, 1) + "%");
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
            TestPlayers.Aqua.AddSpells(TestPlayers.Aqua.CharacterClass.AllowedSpells, spellLevel);
            TestPlayers.Megumin.AddSpell(TestAttackSpells.Explosion, spellLevel);
            TestPlayers.Yunyun.AddSpells(TestPlayers.Yunyun.CharacterClass.AllowedSpells, spellLevel);
            TestPlayers.Sam.AddSpells(TestPlayers.Sam.CharacterClass.AllowedSpells, spellLevel);
            TestPlayers.Lewis.AddSpells(TestPlayers.Lewis.CharacterClass.AllowedSpells, spellLevel);
            TestEnemies.Erlant.AddSpell(TestAttackSpells.Comet, spellLevel);
            TestEnemies.Erlant.AddSpell(TestAttackSpells.Meteor, spellLevel);
            TestEnemies.Erlant.AddSpell(TestAttackSpells.Starfall, spellLevel);
            TestEnemies.Erlant.AddSpell(TestAttackSpells.Nova, spellLevel);

            foreach (BaseEntity entity in TestPlayers.Entities)
            {
                printCharacter(entity);
            }

            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                printAttack(TestPlayers.Entities[r.Next(0, TestPlayers.Entities.Count)], TestPlayers.Entities[r.Next(0, TestPlayers.Entities.Count)], r);
                printAttack(TestPlayers.Entities[r.Next(0, TestPlayers.Entities.Count)], TestEnemies.Erlant, r);
                printAttack(TestEnemies.Erlant, TestPlayers.Entities[r.Next(0, TestPlayers.Entities.Count)], r);
            }

            Console.ReadKey();
        }
    }
}
