using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Hulls
{
    class Hull_BrittleStone : Hull
    {
        public Hull_BrittleStone()
        {

        }

        public override void Initialize()
        {
            SetName("Brittle Stone Hull");
            SetDescription("Hull made out of brittle stone with no damage resistance.");
            SetDurability(8);
            SetDefence(0);
        }
    }
}
