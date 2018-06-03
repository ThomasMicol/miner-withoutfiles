using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Drills
{
    public abstract class Drill:Sprite
    {
        protected int PowerUsage;
        protected int Damage;
        public Drill(Texture2D texture)
            : base(texture)
        {

        }

        public virtual void Initialize()
        {
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
