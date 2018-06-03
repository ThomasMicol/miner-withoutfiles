﻿using Microsoft.Xna.Framework;
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
        protected Drill Drill;
        protected Hull Hull;
        protected Tracks Tracks;
        protected string Cargo;
        protected FuelTank FuelTank;
        protected string Fan;
        protected string Engine;
        protected string FlashLight;
        protected string Battery;
        public float MoveSpeed = 2f;

        public Rig()
        {
            Texture = Context.Content.Load<Texture2D>("sprites/sHull_Base");
            Position = new Vector2((Game1.ScreenWidth / 2) - (Width / 2),
                (Game1.ScreenHeight / 2) - (Height / 2));
            SetFuelTank();
            SetDrill();
            SetOrigin();
            SetTracks();
        }

        public Hull SetHull()
        {
            Hull_BrittleStone hull = new Hull_BrittleStone();
            hull.Initialize();
            return hull;
        }

        public void SetTracks()
        {
            Track_Stone track = new Track_Stone();
            MoveSpeed = track.GetSpeed();
            Tracks = track;
        }

        public void SetDrill()
        {
            Drill = new Drill_BrittleStone();
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
            Drill.Position = new Vector2(Position.X + 4, Position.Y);
        }

        public Drill GetDrill()
        {
            return Drill;
        }

        public void Draw(GameTime aTime)
        {

        }
    }
}
