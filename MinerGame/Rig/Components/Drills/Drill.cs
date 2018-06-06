using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Drills
{
    public abstract class Drill : RigComponent
    {
        protected int Damage;

        public Drill()
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sDrill_Stone");
            ComponentOffset = new Vector2(12, -1);
            Configure();
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

        public float GetPowerUsgae()
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
