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
            if (key.IsKeyDown(Keys.Left))
            {
                velocity.X -= MoveSpeed;
                // Rotation = 180f;
            }
            if (key.IsKeyDown(Keys.Right))
            {
                //Rotation = 0f;
                velocity.X += MoveSpeed;
            }
                

            if (key.IsKeyDown(Keys.Up))
            {
                velocity.Y -= MoveSpeed;
                //Rotation = 90f;
            }
                

            if (key.IsKeyDown(Keys.Down))
            {
                //Rotation = 270f;
                velocity.Y += MoveSpeed;
            }
                

            Position += velocity;
            // Drill.Position = new Vector2(Position.X + 4, Position.Y);
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

            Components.DrawComponents(aTime, batch, Position);
        }
    }
}
