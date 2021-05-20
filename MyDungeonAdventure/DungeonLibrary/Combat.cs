using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(1500);

            if (diceRoll <=(attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed the attack!");
            }
        }

        public static void DoBattle(Hero hero, Monster monster)
        {
            DoAttack(hero, monster);

            if (monster.Life > 0)
            {
                DoAttack(monster, hero);
            }
        }

        public static void DoMagicAttack(Hero hero, Monster monster)
        {
            System.Threading.Thread.Sleep(1500);
            if (hero.Mana >0)
            {
                monster.Life -= 30;
                hero.Mana -= 10;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You have dealt 30 damage to {monster.Name}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{monster.Name} has been stunned");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("But he doesn't have enough mana to cast that");
            }
        }

        public static void UseHealthPotion(Hero hero)
        {

            System.Threading.Thread.Sleep(1500); 
            if (hero.HealthPotions > 0)
            {
                hero.Life += 30;
                hero.HealthPotions --;
                Console.WriteLine("Shaq has restored 30 HP");
                Console.WriteLine($"His current HP is now {hero.Life}");
            }
            else
            {
                Console.WriteLine("You don't have any Health potions");
            }



        }

        public static void UseManaPotion(Hero hero)
        {
            System.Threading.Thread.Sleep(1500);
            if (hero.ManaPotions > 0)
            {
                hero.Mana += 15;
                hero.ManaPotions --;
                Console.WriteLine("Shaq has restored 15 Mana");
            }
            else
            {
                Console.WriteLine("You don't have any Mana potions");
            }
        }


    }
}
