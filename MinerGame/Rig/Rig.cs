﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MinerGame.Buildings;
using MinerGame.Drills;
using MinerGame.Hulls;
using MinerGame.World.Tiles;
using MinerGame.World.Tiles.Ores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerGame
{
    class Rig: Sprite
    {
        protected RigComponentController Components;
        public float MoveSpeed = 2f;
        protected bool Drilling = false;
        protected Chunk Chunk;
        Direction Direction;


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

            Configure();
        }

        public void Update(KeyboardState key, List<Chunk> chunks)
        {
            Vector2 velocity = new Vector2();
            if (key.IsKeyDown(Keys.E))
            {
                foreach (Interactable aInteractable in Chunk.GetMyInteractables())
                {
                    Rectangle InteractableMask = aInteractable.Rectangle;
                    if (Rectangle.Intersects(InteractableMask))
                    {
                        aInteractable.Interact();
                    }
                }
            }
            if (key.IsKeyDown(Keys.A) && PlaceFree(-MoveSpeed, 0, chunks))
            {
                velocity.X -= MoveSpeed;
                Direction = (int)Direction.Left;
                Rotation = MathHelper.ToRadians(180);
            }
            if (key.IsKeyDown(Keys.D) && PlaceFree(MoveSpeed, 0, chunks))
            {
                Direction = Direction.Right;
                velocity.X += MoveSpeed;
                Rotation = MathHelper.ToRadians(0);
            }
            if (key.IsKeyDown(Keys.W) && PlaceFree(0, -MoveSpeed, chunks))
            {
                velocity.Y -= MoveSpeed;
                Direction = Direction.Up;
                Rotation = MathHelper.ToRadians(270);
            }
            if (key.IsKeyDown(Keys.S) && PlaceFree(0, MoveSpeed, chunks))
            {
                Direction = Direction.Down;
                velocity.Y += MoveSpeed;
                Rotation = MathHelper.ToRadians(90);
            }
            if (key.IsKeyDown(Keys.Z))
            {
                Drilling = true;
            }
            else Drilling = false;
            Position += velocity;
            Components.SetComponentsPosition();
            Components.GetDrill().Position = Position + Components.GetDrill().GetOffset();
            SetComponentsOrigin();
        }

        public void SetComponentsOrigin()
        {
            Components.GetDrill().SetRotation(Rotation);
        }

        public bool PlaceFree(float x, float y, List<Chunk> chunks)
        {
            Rectangle RigMask = Rectangle;
            RigMask.Width -= 4;
            RigMask.X += (int)x;
            RigMask.Y += (int)y;

            foreach(Chunk chunk in chunks)
            {
                List<ITile> tiles = chunk.GetTiles();
                foreach(ITile tile in tiles)
                {
                    if ( RigMask.Intersects(tile.Rectangle()) )
                    {
                        DrillWall(tile);
                        // temp destroy wall
                        return false;
                    }
                }
            }

            return true;
        }
        public void CalculateMoveSpeed()
        {
            MoveSpeed = Components.GetTracks().GetSpeed();
        }

        public void SetDrillPosition()
        {
            if (Direction == Direction.Right )
            {

            }
        }
        public void DrillWall(ITile tile)
        {
            if (Direction == Direction.Right )
            {
                if ( tile.GetPosition().X > Position.X )
                {
                    List<ITile> tiles = Chunk.GetTiles();
                    for (int i = 0; i < tiles.Count; i++)
                    {
                        if (tiles[i] == tile)
                        {
                            tiles[i].ReduceHealth(10);
                            if (tiles[i].GetHealth() <= 0)
                            {
                                Components.GetCargo().GetInventory().AddItem(tiles[i].GetDrop());
                                tiles.RemoveAt(i);
                            }
                        }
                    }
                }
            }
        }

        public override void Draw(GameTime aTime, SpriteBatch batch)
        {
            batch.Draw(Texture,
                Position,
                null,
                Color.White,
                Rotation,
                Origin,
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

        public void SetChunk(Chunk chunk)
        {
            Chunk = chunk;
        }
    }
}
