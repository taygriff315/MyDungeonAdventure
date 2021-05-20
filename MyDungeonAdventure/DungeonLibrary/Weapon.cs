using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Weapon
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public bool IsTwoHanded { get; set; }
        public int BonusHitChance { get; set; }

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

        public Weapon(int minDamage, int maxDamage, string name, bool isTwoHanded, int bonusHitChance)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
            IsTwoHanded = isTwoHanded;
            BonusHitChance = bonusHitChance;
        }

        public Weapon()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}\n{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name, MinDamage, MaxDamage, BonusHitChance, IsTwoHanded ? "Two-Handed" : "One-Handed");
        }
    }
}
