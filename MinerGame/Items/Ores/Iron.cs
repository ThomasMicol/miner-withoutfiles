using MinerGame.World.Tiles.Ores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.World.Tiles
{
    class Iron : Item
    {
        public Iron()
        {
            Name = "Iron";
            Description = "Good ol' iron. You will be needing a lot of this";
            Value = 7;
            Weight = 6;
        }
        
    }
}
