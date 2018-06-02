using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Drills
{
    public abstract class Drill:Descriptor
    {
        protected int PowerUsage;
        protected int Damage;
        public Drill() { }

        public virtual void Initialize()
        {
            SetName("Drill");
            SetDescription("Drill Description");
            SetDamage(2);
            SetPowerUsage(1);
        }

        public int GetDamage()
        {
            return Damage;
        }

        public int GetPowerUsgae()
        {
            return PowerUsage;
        }

        public void SetDamage(int damage)
        {
            Damage = damage;
        }

        public void SetPowerUsage(int power)
        {
            PowerUsage = power;
        }
    }
}
