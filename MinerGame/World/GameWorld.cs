using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MinerGame.Buildings;
using MinerGame.World;
using MinerGame.World.Tiles;
using System.Collections.Generic;

namespace MinerGame
{
    class GameWorld
    {
        protected List<Component> MyDrawables = new List<Component>();
        public List<Chunk> MyChunks = new List<Chunk>();
        public Rig Player;
        protected Cursor cursor;
        protected StockPile StockPile;

        KeyboardState currentKeyboardState;
        MouseState currentMouseState;

        public GameWorld()
        {
            GenerateWorld();
            Player = new Rig();
            cursor = new Cursor();
            StockPile = new StockPile(new Vector2(Player.GetPosition().X - 20, Player.GetPosition().Y - 18));
            MyDrawables.Add(Player);
            MyDrawables.Add(cursor);
            MyDrawables.Add(StockPile);
        }

        public void Draw(GameTime aTime, SpriteBatch batch)
        {
            foreach(Component aDrawable in MyDrawables)
            {
                aDrawable.Draw(aTime, batch);
            }
            foreach (Chunk aChunk in MyChunks)
            {
                aChunk.Draw(aTime, batch);
            }
        }

        private void UpdateRig(GameTime gameTime)
        {
            Player.Move(currentKeyboardState, MyChunks);
        }

        public void Update(GameTime gameTime)
        {
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();
            UpdateRig(gameTime);
            CheckCollisions();
        }
        protected void CheckCollisions()
        {
            // Check if player is colliding with chunks, for now just the first one. Will only check current chunk zone eventually
            // kris will do this

            Rectangle PlayerMask = Player.Rectangle;
            foreach(Chunk chunk in MyChunks)
            {
                Rectangle ChunkMask = chunk.GetRectangle();
                if (PlayerMask.Intersects(ChunkMask))
                {
                    Player.SetChunk(chunk);
                }
            }
            /*for(int i = 0; i < Tiles.Count; i ++)
            {
                Wall wall = Walls[i];
                Rectangle wallHitBox = new Rectangle((int)wall.Position.X, (int)wall.Position.Y, wall.Width, wall.Height);
                if (wallHitBox.Intersects(DrillHitMask))
                {
                    Walls.RemoveAt(i);
                }
            }*/
        }
        protected void GenerateWorld()
        {
            MyChunks.Add(new SpawnChunk());
            GenerateChunk(1, 1);
            GenerateChunk(1, 0);
            GenerateChunk(1, -1);
            GenerateChunk(-1, 1);
            GenerateChunk(-1, 0);
            GenerateChunk(-1, -1);
            GenerateChunk(0, 1);
            GenerateChunk(0, -1);
        }

        protected Chunk GenerateChunk(int x, int y)
        {
            Chunk chunk = new Chunk(new Vector2(x, y));
            MyChunks.Add(chunk);
            return chunk;
        }

    }
}