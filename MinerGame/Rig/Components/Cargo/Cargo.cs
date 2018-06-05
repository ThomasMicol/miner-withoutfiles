using System.Collections.Generic;

namespace MinerGame
{
    public class Cargo : RigComponent
    {
        protected int MaxSize;
        protected Inventory Inventory;

        public void Initialize()
        {
            Inventory = new Inventory();
            Inventory.SetInventoryCapacity(MaxSize);
        }

        public Inventory GetInventory()
        {
            return Inventory;
        }
    }
}