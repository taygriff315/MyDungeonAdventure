using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   public class Potion
    {
        public string Name { get; set; }
        public int Restored { get; set; }


        public Potion(string name, int restored)
        {
            Name = name;
            Restored = restored;
        }

        public Potion()
        {

        }

        public override string ToString() => $"Restores {Restored} {Name}";
       
    }
}
