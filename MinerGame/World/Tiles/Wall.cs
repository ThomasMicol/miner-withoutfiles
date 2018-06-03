using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.World.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    class Wall: Sprite, ITile
    {
        public Wall(Vector2 aPosition)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sWall");
            Position = aPosition;
        }
    }
}
