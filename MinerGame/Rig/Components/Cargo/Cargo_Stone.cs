using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Cargo_Stone:Cargo
    {
        public Cargo_Stone()
        {
            MaxSize = 5;
            Initialize();

            Inventory.AddItem(new Item("item", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item5", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item6", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item7", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item8", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item9", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item11", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item111", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item1111", "hardcoded", "rare", 5, 20));
            Inventory.AddItem(new Item("item", "hardcoded", "rare", 5, 20));
        }
    }
}
