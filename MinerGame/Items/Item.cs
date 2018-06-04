using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Item : Sprite
    {
        protected string Name;
        protected string Description;
        protected string Rarity;
        protected int Value;
        protected int Weight;
        protected int Count;
        protected int StackSize;

        public Item()
        {
            Name = "name";
            Description = "description";
            Rarity = "rarity";
            Value = 1;
            StackSize = 1;
            Count = 0;
        }

        public void AddCount(int count)
        {
            Count += count;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName() { return Name; }

        public int GetCount() { return Count; }
        public int GetStackSize() { return StackSize; }
    }
}
