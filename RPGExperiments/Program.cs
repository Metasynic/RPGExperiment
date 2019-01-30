using System;
using System.Linq;
using System.Collections.Generic;
using RPGExperiments.Entities;
using RPGExperiments.Spells;

namespace RPGExperiments
{
    public class Program
    {
        static void PrintAttack(BaseEntity attacker, BaseEntity target, Random r)
        {
            if (attacker.Spells.Count != 0) {
                if (r.Next(3) == 0)
                {
                    PrintPhysicalAttack(attacker, target, r);
                }
                else
                {
                    PrintSpell(attacker, target, r);
                }
            }
            else
            {
                PrintPhysicalAttack(attacker, target, r);
            }
        }

        static void PrintCharacter(BaseEntity b)
        {
            Console.WriteLine(b.Name.PadRight(9) + " Lv: " + b.Level + " BST: " + (b as PlayerEntity).BaseStatTotal + " HP: " + b.MaxHealth + " MP: " + b.MaxMana + " Atk: " + b.PhysAtk + " Def: " + b.PhysDef + " BMag: " + b.BlackMag + " WMag: " + b.WhiteMag + " MDef: " + b.MagDef + " Hit: " + b.HitRate + " Spd: " + b.Speed + " Crm: " + b.Charm + " FST: " + (b.PhysAtk + b.PhysDef + b.BlackMag + b.WhiteMag + b.MagDef + b.HitRate + b.Speed + b.Charm) + " Crit: " + Math.Round(b.CritRate * 100, 1) + "%");
        }

        static void PrintPhysicalAttack(BaseEntity attacker, BaseEntity defender, Random r)
        {
            DamageInfo damageInfo = attacker.PhysicalAttackDamage(defender, r);
            if (damageInfo.Critical)
                Console.WriteLine("Critical Hit:");
            else if (damageInfo.Glancing)
                Console.WriteLine("Glancing Blow:");
            Console.WriteLine(attacker.Name + " does " + damageInfo.Damage + " damage to " + defender.Name + ".");
        }

        static void PrintSpell(BaseEntity attacker, BaseEntity defender, Random r) {
            BaseSpell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " for " + attacker.CastSpell(spell, defender, r));
        }

        static void CastOnAll(BaseEntity attacker, List<BaseEntity> defenders, Random r)
        {
            BaseSpell spell = attacker.Spells.Keys.ElementAt(r.Next(0, attacker.Spells.Keys.Count));
            foreach(BaseEntity defender in defenders)
            {
                Console.WriteLine(attacker.Name + " cast " + spell.Name + " on " + defender.Name + " for " + attacker.CastSpell(spell, defender, r));
            }
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
                PrintCharacter(entity);
            }

            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                PrintAttack(TestPlayers.Entities[r.Next(TestPlayers.Entities.Count)], TestPlayers.Entities[r.Next(TestPlayers.Entities.Count)], r);
            }
            foreach (PlayerEntity p in TestPlayers.Entities)
            {
                PrintAttack(p, TestEnemies.Erlant, r);
            }
            CastOnAll(TestEnemies.Erlant, TestPlayers.Entities, r);

            Console.ReadKey();
        }
    }
}
