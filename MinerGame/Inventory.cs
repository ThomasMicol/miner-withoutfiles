using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Inventory
    {
        protected List<Item> Items;
        protected int Capacity;
        public void AddItem(Item item)
        {

            if ( Items.Count > 0 )
            {
                foreach(Item _item in Items)
                {
                    List<Item> tempItemList = Items.Where(_i => _i.GetName() == item.GetName()).ToList();
                }
            }
            if ( Items.Count < Capacity)
            {
                Items.Add(item);
            }
            
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public Item GetItem(Item item)
        {
            return item;
        }

        public int GetSize()
        {
            return 0;
        }

        public Inventory()
        {
            Items = new List<Item>();
            
        }

        public void SetInventoryCapacity(int capacity)
        {
            Capacity = capacity;
        }
    }
}
