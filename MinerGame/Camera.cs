using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    class Camera
    {
        public Matrix Transform { get; private set; }

        public void Follow(Sprite target)
        {

            var position = Matrix.CreateTranslation(
                    Game1.ScreenWidth / 2,
                Game1.ScreenHeight / 2,
                0);

            var offset = Matrix.CreateTranslation(
                -target.Position.X - (target.Rectangle.Width / 2),
                -target.Position.Y - (target.Rectangle.Height / 2),
                0);
            Transform = position * offset;
        }

        public void draw(SpriteBatch spriteBatch)
        {

        }
    }
}
