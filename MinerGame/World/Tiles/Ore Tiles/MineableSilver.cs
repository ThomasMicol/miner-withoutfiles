using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.World.Tiles.Ores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.World.Tiles.Ore_Tiles
{
    class MineableSilver : MineableTile
    {
        public MineableSilver(Vector2 aPosition) : base(aPosition)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sCursor");
            MyDrop = new Silver();
        }
    }
}
