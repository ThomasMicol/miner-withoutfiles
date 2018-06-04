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
    class MineableCoal : MineableTile, ITile
    {
        public MineableCoal(Vector2 aPosition) : base(aPosition)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sStone_Coal");
            MyDrop = new Coal();
        }

        Rectangle ITile.Rectangle()
        {
            return Rectangle;
        }
    }
}
