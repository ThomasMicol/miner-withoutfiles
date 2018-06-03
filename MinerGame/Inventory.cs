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
            bool found = false;
            if ( Items.Count > 0 )
            {
                foreach(Item _item in Items)
                {
                    List<Item> tempItemList = Items.Where(_i => _i.GetName() == item.GetName()).ToList();

                    foreach(Item tempItem in tempItemList)
                    {
                        if(tempItem.GetCount() < tempItem.GetStackSize())
                        {
                            tempItem.AddCount(1);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
            }
            if ( !found )
            {
                if (Items.Count < Capacity)
                {
                    Items.Add(item);
                    item.AddCount(1);
                }
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
            return Items.Count;
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
