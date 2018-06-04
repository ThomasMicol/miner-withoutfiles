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
    class MineableIron : MineableTile, ITile 
    {
        public MineableIron(Vector2 aPosition) : base(aPosition)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sStone_Iron");
            MyDrop = new Item_Iron();
        }

        public int GetHealth()
        {
            return Health;
        }

        public void ReduceHealth(int value)
        {
            Health -= 1;
        }

        Rectangle ITile.Rectangle()
        {
            return Rectangle;
        }
    }
}
