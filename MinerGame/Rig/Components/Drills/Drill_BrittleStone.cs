using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Drills
{
    class Drill_BrittleStone:Drill
    {
        public Drill_BrittleStone()
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sDrill_Stone");
            //SetFuelTank();
        }
        public override void Initialize()
        {
            SetDamage(2);
            SetPowerUsage(1);
        }
    }
}
