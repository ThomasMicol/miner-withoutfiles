using Microsoft.Xna.Framework;
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
            if (key.IsKeyDown(Keys.A))
            {
                SetDirectionAndRotation(Direction.Left, 180);
                if (PlaceFree(-MoveSpeed, 0, chunks)) velocity.X -= MoveSpeed;
            }
            if (key.IsKeyDown(Keys.D) )
            {
               SetDirectionAndRotation(Direction.Right, 0);
                if ( PlaceFree(MoveSpeed, 0, chunks) ) velocity.X += MoveSpeed;
            }
            if (key.IsKeyDown(Keys.W))
            {
                SetDirectionAndRotation(Direction.Up, 270);
                if (PlaceFree(0, -MoveSpeed, chunks)) velocity.Y -= MoveSpeed;
            }
            if (key.IsKeyDown(Keys.S))
            {
                SetDirectionAndRotation(Direction.Down, 90);
                if (PlaceFree(0, MoveSpeed, chunks)) velocity.Y += MoveSpeed;
            }
            else Drilling = false;
            Position += velocity;
            Components.SetComponentsPosition();
            SetComponentsOrigin();
            SetDrillPosition();
        }

        public void SetDirectionAndRotation(Direction direction, float rotation)
        {
            Direction = direction;
            Rotation = MathHelper.ToRadians(rotation);
        }
        public void SetComponentsOrigin()
        {
            Components.GetDrill().SetRotation(Rotation);
        }

        public Chunk GetCurrentChunk()
        {
            return Chunk;
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
            Drill _targetDrill = Components.GetDrill();
            Vector2 _targetDrillOffset = _targetDrill.GetOffset();
            if (Direction == Direction.Right )
            {
                _targetDrill.Position = Position + _targetDrillOffset;
            }

            else if (Direction == Direction.Left)
            {
                _targetDrill.Position = Position - _targetDrillOffset;
            }

            else if (Direction == Direction.Up)
            {
                Vector2 flip = new Vector2(_targetDrillOffset.Y + 2, _targetDrillOffset.X);
                _targetDrill.Position = Position - flip;
            }

            else if (Direction == Direction.Down)
            {
                Vector2 flip = new Vector2(_targetDrillOffset.Y + 2, _targetDrillOffset.X);
                _targetDrill.Position = Position + flip;
            }
        }
        public void DrillWall(ITile tile, List<ITile> tiles)
        {
            tile.ReduceHealth(5);
            if ( tile.GetHealth() <= 0)
            {
                Components.GetCargo().GetInventory().AddItem(tile.GetDrop());
                tiles.Remove(tile);
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
