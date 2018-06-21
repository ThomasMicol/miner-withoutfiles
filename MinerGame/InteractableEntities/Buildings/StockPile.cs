using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.Interactable.Interactable_UI.Buildings;
using MinerGame.The_Interactables;
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
            myUI = new StockPileUI(this);
            Position = aPosition;
        }
    }
}
