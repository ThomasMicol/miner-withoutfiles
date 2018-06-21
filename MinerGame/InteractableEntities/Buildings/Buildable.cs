using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame.Buildings
{
    class Buildable : Interactable
    {
        protected Rectangle Mask;

        public override void Interact()
        {
            myUI.Draw();
        }
    }
}
