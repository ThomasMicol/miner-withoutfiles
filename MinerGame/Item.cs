using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Item:Sprite
    {
        protected string Name;
        protected string Description;
        protected string Rarity;
        protected int Value;
        protected int Count;
        protected int StackSize;

        public Item(string name, string description, string rarity, int value, int stackSize)
        {
            Name = name;
            Description = description;
            Rarity = rarity;
            Value = value;
            StackSize = stackSize;
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
