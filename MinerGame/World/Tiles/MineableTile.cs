using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.World.Tiles.Ores
{
    class MineableTile : Sprite
    {
        protected Item MyDrop;
        protected int Health;

        public MineableTile(Vector2 aPostion)
        {
            Position = aPostion;
            Health = 100;
        }
    }
}
