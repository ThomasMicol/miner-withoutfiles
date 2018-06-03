using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public abstract class FuelTank : RigComponent
    {
        public float LitresMax { get; set; }
        public float Litres { get; set; }
        public float FuelEffieciency { get; set; }
        protected Texture2D Icon;

        public FuelTank()
        {

        }

        public void SetFuel(int fuel)
        {
            LitresMax = fuel;
            Litres = fuel;
        }

        public void SetFuelEffieciency(float decimalPercentage)
        {
            FuelEffieciency = decimalPercentage;
        }
    }
}
