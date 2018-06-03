using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Item_Iron:Item
    {
        public Item_Iron()
        {
            Name = "Iron Ore";
            Description = "This is Iron ore.";
            Value = 10;
            Count = 0;
            Rarity = "Common";
            StackSize = 15;
        }
    }
}
