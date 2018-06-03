using MinerGame.World.Tiles.Ores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.World.Tiles
{
    class Silver : Item
    { 
        public Silver()
        {
            Name = "Silver";
            Description = "Half as shiney as gold; half as heavy too";
            Value = 10;
            Weight = 5;
        }
    }
}
