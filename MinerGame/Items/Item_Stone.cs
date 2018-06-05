using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Items
{
    public class Item_Stone:Item
    {
        public Item_Stone()
        {
            Name = "Stone";
            Description = "This is Stone.";
            Value = 1;
            Count = 0;
            Rarity = "Common";
            StackSize = 100;
        }
    }
}
