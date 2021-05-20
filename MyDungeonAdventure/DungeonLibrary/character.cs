using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public abstract class Character
    {
        private int _life;

        public int MaxLife { get; set; }
        public int AtkDamage { get; set; }
        public int Block { get; set; }
        public int HitChance { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public int Life
        {
            get { return _life; }
            set
            {
                if (value <=MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }

     public Character(int maxLife, int atkDamage, int block, int hitChance, string name, string description)
        {

            
            MaxLife = maxLife;
            AtkDamage = atkDamage;
            Block = block;
            HitChance = hitChance;
            Name = name;
            Description = description;


        }

        public Character()
        {

        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }
}
