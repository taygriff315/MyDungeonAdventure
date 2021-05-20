using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Hero : Character
    {
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Spell Magic { get; set; }
        public int Mana { get; set; }
        public int HealthPotions { get; set; }
        public int ManaPotions { get; set; }

        public Hero(string name, Race characterRace, Weapon equippedWeapon, Spell magic, int life, int maxLife, int atkDamage, int block, int hitChance, int mana, int healthPotions, int manaPotions, string description): base(maxLife,atkDamage,block,hitChance,name,description)
        {
            Mana = mana;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Magic = magic;
            HealthPotions = healthPotions;
            ManaPotions = manaPotions;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return string.Format("--{0}--\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon: {4}\n" +
                "Magic: {5}\n" +
                "Mana: {8}\n" +
                "Block: {6}\n" +
                "Description: {7}\n", Name, Life, MaxLife, HitChance, EquippedWeapon, Magic, Block, Description, Mana);
        }
        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
