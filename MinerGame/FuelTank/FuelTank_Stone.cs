using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class FuelTank_Stone:FuelTank
    {
        public FuelTank_Stone()
        {
            SetFuel(20);
            SetFuelEffieciency(0.5f);
        }
    }
}
