using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Witch: Monster
    {
        public Spell DarkMagic { get; set; }

        public Witch(string name, int life, int maxLife, int atkDamage, int hitChance, int block, int minDamage, int maxDamage, string description, string image, Spell darkMagic) : base(name, life, maxLife, atkDamage, hitChance, block, minDamage, maxDamage, description, image)
        {
       
            DarkMagic = darkMagic;
          
        }

        public override string ToString()
        {
            return base.ToString();
        }
                
                 





    };
}
