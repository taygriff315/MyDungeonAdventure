using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Zombie : Monster
    {
        

        public Zombie(string name, int life, int maxLife, int atkDamage, int hitChance, int block, int minDamage, int maxDamage, string description, string image):base(name, life, maxLife, atkDamage, hitChance, block, minDamage, maxDamage, description, image)
        {
            Life = life;

            if (Life < 11)
            {
                hitChance += 10;
                block += 10;
                minDamage += 5;
                maxDamage += 10;
            }
        }
        public override string ToString()
        {
            return base.ToString()+ (Life > 11 ? "" : "The weaker it gets, the stronger it becomes..");
        }
    }
}
