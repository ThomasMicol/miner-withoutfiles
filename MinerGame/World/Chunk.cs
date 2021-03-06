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
        protected List<Interactable> MyInteractables = new List<Interactable>();
        protected Rectangle Rectangle;
        protected int ScreenHeight;
        protected int ScreenWidth;
        protected int Height = 24;
        protected int Width = 24;
        protected int TileWidth = 24;
        protected int TileSize = 24;
        protected int TileHeight = 24;

        public Chunk(Vector2 aPos)
        {
            ScreenWidth = 320;
            ScreenHeight = 240;
            Width = ScreenWidth / TileSize;
            Height = ScreenHeight / TileSize;
            Position = aPos;
            GenerateChunkMask();
            GenerateChunkContent();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach(ITile aTile in MyTiles)
            {
                aTile.Draw(gameTime, spriteBatch);
            }
            foreach(Interactable aInteractable in MyInteractables)
            {
                aInteractable.Draw(gameTime, spriteBatch);
            }
        }

        public override void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void GenerateChunkMask()
        {
            // Stop using points
            Point postopoint = new Point((int)Position.X * ScreenWidth, (int)Position.Y * ScreenHeight);
            Point size = new Point((TileWidth * Width) + ((int)Position.X * ScreenWidth), (TileHeight * Height) + ((int)Position.Y * ScreenHeight));
            Rectangle = new Rectangle(postopoint,size);
        }

        protected virtual void GenerateChunkContent()
        {

            Random rnd = new Random();
            int seed;

            // What the fuck is this
            //i dont want to fucking talk about it
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    seed = rnd.Next(0,100);
                    if (seed <= 1)
                    {
                        Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (TileSize * x), (Position.Y * ScreenHeight) + (TileSize * y));
                        ITile tile = new MineableSilver(TilePosition);
                        MyTiles.Add(tile);
                    }
                    else
                    {
                        if (seed <= 3)
                        {
                            Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (TileSize * x), (Position.Y * ScreenHeight) + (TileSize * y));
                            ITile tile = new MineableIron(TilePosition);
                            MyTiles.Add(tile);
                        }
                        else
                        {
                            if (seed <= 6)
                            {
                                Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (TileSize * x), (Position.Y * ScreenHeight) + (TileSize * y));
                                ITile tile = new MineableCoal(TilePosition);
                                MyTiles.Add(tile);
                            }
                            else
                            {
                                if (seed > 6)
                                {
                                    Vector2 TilePosition = new Vector2((Position.X * ScreenWidth) + (TileSize * x), (Position.Y * ScreenHeight) + (TileSize * y));
                                    ITile tile = new Wall(TilePosition);
                                    MyTiles.Add(tile);
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<ITile> GetTiles()
        {
            return MyTiles;
        }

        public Rectangle GetRectangle()
        {
            return Rectangle;
        }

        public List<Interactable> GetMyInteractables()
        {
            return MyInteractables;
        }
    }
}