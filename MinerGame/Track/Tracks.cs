using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public abstract class Tracks
    {
        protected float Speed;

        public Tracks()
        {
            Speed = 1f;
        }

        public float GetSpeed()
        {
            return Speed;
        }
    }
}
