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
    public class Rig: Sprite
    {
        protected RigComponentController Components;
        public float MoveSpeed = 2f;
        protected bool Drilling = false;


        public Rig()
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sHull_Base");
            Position = new Vector2((Game1.ScreenWidth / 2) - (Width / 2),
                (Game1.ScreenHeight / 2) - (Height / 2));
            Components = new RigComponentController();
            Components.SetFuelTank(new FuelTank_Stone());
            Components.SetDrill(new Drill_BrittleStone());
            Components.SetTracks(new Track_Stone());
            Components.SetCargo(new Cargo_Stone());
            CalculateMoveSpeed();
        }


        public void Move(KeyboardState key)
        {
            Vector2 velocity = new Vector2();
            if (key.IsKeyDown(Keys.A))
            {
                velocity.X -= MoveSpeed;
                // Rotation = 180f;
            }
            if (key.IsKeyDown(Keys.D))
            {
                //Rotation = 0f;
                velocity.X += MoveSpeed;
            }
                

            if (key.IsKeyDown(Keys.W))
            {
                velocity.Y -= MoveSpeed;
                //Rotation = 90f;
            }
                

            if (key.IsKeyDown(Keys.S))
            {
                //Rotation = 270f;
                velocity.Y += MoveSpeed;
            }

            if (key.IsKeyDown(Keys.Z))
            {
                Drilling = true;
            }
            else Drilling = false;
            Position += velocity;
            Components.GetDrill().Position = Position + Components.GetDrill().GetOffset();
        }

        public void CalculateMoveSpeed()
        {
            MoveSpeed = Components.GetTracks().GetSpeed();
        }

        public override void Draw(GameTime aTime, SpriteBatch batch)
        {
            batch.Draw(Texture,
                Position,
                null,
                Color.White,
                0f,
                Vector2.Zero,
                1f,
                SpriteEffects.None, 0f);

            Components.DrawComponents(aTime, batch);
        }

        public bool GetDrilling()
        {
            return Drilling;
        }

        public RigComponentController GetComponents()
        {
            return Components;
        }
    }
}
