using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Spell
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public int Mana { get; set; }
        public string Name { get; set; }

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

        public Spell(int minDamage, int maxDamage, int mana, string name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Mana = mana;
            Name = name;
        }

        public Spell()
        {

        }

        public override string ToString() => $"A powerful {Name} spell.";


       

    }
}
