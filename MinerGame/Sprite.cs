using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Sprite: Component
    {
        protected Texture2D Texture;
        public Vector2 Position { get; set; }
        public Vector2 Origin = new Vector2(0, 0);
        public int Width
        {
            get { return Texture.Width; }
        }

        public int Height
        {
            get { return Texture.Height; }
        }

        public Rectangle Rectangle
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }

        public override void Update(GameTime gameTime)
        {

        }

        public Sprite(Texture2D texture)
        {
            Texture = texture;
        }
    }
}
