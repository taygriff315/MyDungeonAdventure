using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Skeleton : Monster
    {
        public Skeleton(string name, int life, int maxLife, int atkDamage, int hitChance, int block, int minDamage, int maxDamage, string description, string image) : base(name, life, maxLife, atkDamage, hitChance, block, minDamage, maxDamage, description, image)
        {

            if (Life > 40)
            {
                hitChance += 10;
                block += 10;
                minDamage += 5;
                maxDamage += 10;
            }
        }

        public override string ToString()
        {
            return base.ToString() + (Life > 40 ? "Gonna have to soften him up" : "He's weak, now's my chance!");
        }
    }
}
