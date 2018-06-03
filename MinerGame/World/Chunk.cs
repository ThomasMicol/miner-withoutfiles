using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.World.Tiles;
using System.Collections.Generic;

namespace MinerGame
{
    class Chunk : Component
    {
        protected Point Position;
        protected List<ITile> MyTiles = new List<ITile>();
        protected static int Height = 32;
        protected static int Width = 32;
        protected int TileWidth;
        protected int TileHeight;

        public Chunk(Point aPos)
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