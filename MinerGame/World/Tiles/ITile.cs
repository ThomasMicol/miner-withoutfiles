using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.World.Tiles
{
    interface ITile
    {
        void Draw(GameTime gameTime, SpriteBatch spriteBatch);
        Vector2 GetPosition();
    }
}
