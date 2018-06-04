using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using MinerGame.World.Tiles;

namespace MinerGame.World
{
    class SpawnChunk : Chunk
    {
        public SpawnChunk() : base(new Vector2(0, 0)){}

        protected override void GenerateChunkContent()
        {
            for (int x = 0; x < Width; x++)
            {   
                for (int y = 0; y < Height; y++)
                {
                    Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (16 * x), (Position.Y * ScreenHeight) + (16 * y));
                    ITile tile = new Wall(TilePosition);
                    MyTiles.Add(tile);
                }
            }
            CreateRoom(10, 10, new Vector2(32, 32));

            return;
        }

        public void CreateRoom(int width, int height, Vector2 startPos)
        {
            // Find center of 'chunk'
            int cX, cY;
            cX = (int)Math.Floor((decimal)ScreenWidth / 16) / 2;
            cY = (int)Math.Floor((decimal)ScreenHeight / 16) / 2;
            cX -= width / 2;
            cY -= height / 2;
            startPos = new Vector2(cX * 16, cY * 16);
            for (int i = 0; i < width; i++)
            {
                for (int h = 0; h < height; h++)
                {
                    Rectangle Mask = new Rectangle((int)startPos.X + (16 * i), (int)startPos.Y + (16 * h), 16, 16);
                    Wall targetWall = (Wall)MyTiles.Where(aWall => aWall.GetPosition().X == Mask.X && aWall.GetPosition().Y == Mask.Y).FirstOrDefault();
                    MyTiles.Remove(targetWall);
                }
            }
        }
    }
}
