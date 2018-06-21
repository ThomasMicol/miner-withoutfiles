using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MinerGame.Buildings
{
    class OreExporter : Buildable
    {
        public OreExporter(Vector2 aPos)
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sBuilding_OreExporter");
            Position = aPos;
        }

        public override void Interact()
        {
            Console.WriteLine("You sell all your shit");
        }
    }
}
