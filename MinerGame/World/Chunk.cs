using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.World.Tiles;
using System.Collections.Generic;

namespace MinerGame
{
    class Chunk : Component
    {
        protected Vector2 Position;
        protected List<ITile> MyTiles = new List<ITile>();
        protected static int Height = 16;
        protected static int Width = 16;
        protected int TileWidth;
        protected int TileHeight;

        public Chunk(Vector2 aPos)
        {
            Position = aPos;
            GenerateChunkContent();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

        protected void GenerateChunkContent()
        {
            for(int x = 0; x > Height; x++)
            {
                for (int y = 0; y > Height; y++)
                {
                    MyTiles.Add(new Wall());
                }
            }
        }
    }
}