using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Image { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public Monster(string name, int life, int maxLife, int atkDamage, int hitChance, int block, int minDamage, int maxDamage, string description, string image):base(maxLife, atkDamage, block, hitChance, name, description)
        {

            Life = life;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Image = image;
        }

        public Monster()
        {

        }

        public override string ToString()
        {
            return string.Format("\n****ENEMY****\n" +
                "{0}\n" +
                "Life: {1} of {2}" +
                "Damage: {3}-{4}" +
                "Block: {5}\n" +
                "Description:\n{6}\n", Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
