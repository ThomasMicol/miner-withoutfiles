﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.World.Tiles;
using MinerGame.World.Tiles.Ore_Tiles;
using System;
using System.Collections.Generic;

namespace MinerGame
{
    class Chunk : Component
    {
        protected Vector2 Position;
        protected List<ITile> MyTiles = new List<ITile>();
        protected int ScreenHeight;
        protected int ScreenWidth;
        protected int Height = 16;
        protected int Width = 16;
        protected int TileWidth = 16;
        protected int TileHeight = 16;

        public Chunk(Vector2 aPos)
        {
            ScreenWidth = 320;
            ScreenHeight = 240;
            Width = ScreenWidth / 16;
            Height = ScreenHeight / 16;
            Position = aPos;
            GenerateChunkContent();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach(ITile aTile in MyTiles)
            {
                aTile.Draw(gameTime, spriteBatch);
            }
        }

        public override void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void GenerateChunkContent()
        {
            for(int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Random rnd = new Random();
                    int seed;
                    seed = rnd.Next(0,100);
                    if(seed >= 50)
                    {
                        Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (16 * x), (Position.Y * ScreenHeight) + (16 * y));
                        ITile tile = new Wall(TilePosition);
                        MyTiles.Add(tile);
                    }
                    else
                    {
                        Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (16 * x), (Position.Y * ScreenHeight) + (16 * y));
                        ITile tile = new MineableIron(TilePosition);
                        MyTiles.Add(tile);
                    }
                    
                }
            }
        }
    }
}