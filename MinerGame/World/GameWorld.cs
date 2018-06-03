using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MinerGame
{
    class GameWorld
    {
        protected List<Component> MyDrawables = new List<Component>();
        protected List<Chunk> MyChunks = new List<Chunk>();
        public Rig Player;
        protected Cursor cursor; 

        public GameWorld()
        {
            GenerateWorld();
            Player = new Rig();
            cursor = new Cursor();
            MyDrawables.Add(Player);
            MyDrawables.Add(cursor);
        }

        public void Draw(GameTime aTime, SpriteBatch batch)
        {
            foreach(Component aDrawable in MyDrawables)
            {
                aDrawable.Draw(aTime, batch);
            }
           // foreach(Chunk aChunk in MyChunks)
           // {
           //     aChunk.Draw(aTime, batch);
           // }
        }

        protected void GenerateWorld()
        {
            GenerateChunk(1, 1);
            GenerateChunk(1, 0);
            GenerateChunk(1, -1);
            GenerateChunk(-1, 1);
            GenerateChunk(-1, 0);
            GenerateChunk(-1, -1);
            GenerateChunk(0, 1);
            GenerateChunk(0, -1);
        }

        protected void GenerateChunk(int x, int y)
        {
            MyChunks.Add(new Chunk(new Vector2(x, y)));
        }

    }
}