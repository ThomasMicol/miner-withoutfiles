using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MinerGame.Drills;
using MinerGame.Hulls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    public class Rig:Sprite
    {
        protected Drill Drill;
        protected Hull Hull;
        protected string Tracks;
        protected string Cargo;
        protected FuelTank FuelTank;
        protected string Fan;
        protected string Engine;
        protected string FlashLight;
        protected string Battery;
        public float MoveSpeed = 2f;

        public Rig(Texture2D texture)
            : base(texture)
        {
            SetFuelTank();
        }

        public Hull SetHull()
        {
            Hull_BrittleStone hull = new Hull_BrittleStone();
            hull.Initialize();
            return hull;
        }
        public void SetOrigin()
        {
            // comment
        }

        public Drill SetDrill(Texture2D texture)
        {
            Drill drill = new Drill_BrittleStone(texture);
            drill.Initialize();
            Drill = drill;
            return drill;
        }

        public FuelTank SetFuelTank()
        {
            FuelTank fuelTank = new FuelTank_Stone();
            return fuelTank;
        }

        public void Move(KeyboardState key)
        {
            Vector2 velocity = new Vector2();
            if (key.IsKeyDown(Keys.Left))
                velocity.X -= MoveSpeed;

            if (key.IsKeyDown(Keys.Right))
                velocity.X += MoveSpeed;

            if (key.IsKeyDown(Keys.Up))
                velocity.Y -= MoveSpeed;

            if (key.IsKeyDown(Keys.Down))
                velocity.Y += MoveSpeed;

            Position += velocity;
            Drill.Position = new Vector2(Position.X + 4, Position.Y);
        }

        public Drill GetDrill()
        {
            return Drill;
        }
    }
}
