using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace MinerGame.World
{
    class SpawnChunk : Chunk
    {
        public SpawnChunk() : base(new Vector2(0, 0)){}

        protected override void GenerateChunkContent()
        {
            return;
        }
    }
}
