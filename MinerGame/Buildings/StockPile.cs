using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Buildings
{
    class StockPile : Buildable
    {
        public StockPile(Vector2 aPosition)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sBuilding_StockPile");
            Position = aPosition;
        }

        public override void Interact()
        {
            Console.WriteLine("you store your stuff");
        }
    }
}
