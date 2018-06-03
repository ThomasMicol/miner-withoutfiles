using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    class Cursor : Component
    {
        public Texture2D Sprite;
        public bool Active;
        public Vector2 Position;

        public Cursor()
        {
            Sprite = Context.Content.Load<Texture2D>("sprites/sCursor");
        }

        public int Width
        {
            get { return Sprite.Width; }
        }

        public int Height
        {
            get { return Sprite.Height; }
        }

        public void Initialize(Vector2 position)
        {
            Position = position;
            Active = true;
        }

        public override void Update(GameTime aTime)
        {
            MouseState mPos = Mouse.GetState();
            Position = new Vector2(mPos.X, mPos.Y);
        }

        public override void Draw(GameTime aTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite,
                Position,
                null,
                Color.White,
                0f,
                Vector2.Zero,
                1f,
                SpriteEffects.None, 0f);
        }
    }
}
