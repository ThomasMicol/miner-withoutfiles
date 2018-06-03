using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public abstract class Hull : RigComponent
    {
        protected int DurabilityMax;
        protected int Durability;
        protected int Defence;

        public Hull()
        {

        }

        public virtual void Initialize()
        {
            SetName("Hull");
            SetDescription("Hull Description");
            SetDurability(1);
            SetDefence(1);
        }

        #region Setters
        public void SetDurability(int durability)
        {
            DurabilityMax = durability;
            Durability = DurabilityMax;
        }

        public void SetDefence(int defence)
        {
            Defence = defence;
        }
        #endregion
    }
}
