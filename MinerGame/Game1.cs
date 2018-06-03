using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinerGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        internal GameWorld MyWorld { get; private set; }

        KeyboardState currentKeyboardState;
        //KeyboardState previousKeyboardState;
        MouseState currentMouseState;
        //MouseState previousMouseState;
        private Camera Camera;
        //private List<Component> Components;
        public static int ScreenHeight;
        public static int ScreenWidth;

        // Camera camera;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            SetWindowSize(graphics);
        }

        private void SetWindowSize(GraphicsDeviceManager graphics)
        {
            graphics.PreferredBackBufferWidth = 320;
            graphics.PreferredBackBufferHeight = 240;

            ScreenHeight = graphics.PreferredBackBufferHeight;
            ScreenWidth = graphics.PreferredBackBufferWidth;
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Component.Context = this;
            MyWorld = new GameWorld();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Vector2 rigPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);

            int wallCountWidth = graphics.PreferredBackBufferWidth / 16;
            int WallCountHeight = graphics.PreferredBackBufferHeight / 16;
            for (int i = 0; i < wallCountWidth; i ++)
            {
                for(int j = 0; j < WallCountHeight; j ++)
                {
                    Vector2 wallPosition = new Vector2(0 + (16 * i), 0 + (16 * j));
                    Wall wall = new Wall();
                    wall.Position = wallPosition;
                    //Walls.Add(wall);
                }
            }

            CreateRoom(8, 8, new Vector2(32, 32));

            Camera = new Camera();
            // Components = new List<Component>()
            //{
                //player
            //};
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MouseState mousePos = Mouse.GetState();
            // TODO: Add your update logic here
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();
            UpdateRig(gameTime);
            CollisionChecks();
            Camera.Follow(MyWorld.Player);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(transformMatrix: Camera.Transform);
            MyWorld.Draw(gameTime, spriteBatch);
            //foreach(Wall wall in Walls)
            //{
            //    wall.Draw(gameTime, spriteBatch);
            //}
            //player.Draw(gameTime, spriteBatch);
            //player.GetDrill().Draw(gameTime, spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        private void UpdateRig(GameTime gameTime)
        {
            MyWorld.Player.Move(currentKeyboardState);
        }

        private void CreateRoom(int width, int height, Vector2 startPos)
        {
            // Find center of 'chunk'
            int cX, cY;
            //cX = (int)Math.Floor((decimal)ScreenWidth / 16) / 2;
            //cY = (int)Math.Floor((decimal)ScreenHeight / 16) / 2;
            //cX -= width / 2;
            //cY -= height / 2;
            //startPos = new Vector2(cX * 16, cY * 16);
            //for ( int i = 0; i < width; i ++ )
            //{
            //    for ( int h = 0; h < height; h ++)
            //    {
            //        Rectangle Mask = new Rectangle((int)startPos.X + (16 * i), (int)startPos.Y + (16 * h), 16, 16);
            //        Wall targetWall = Walls.Where(aWall => aWall.Position.X == Mask.X && aWall.Position.Y == Mask.Y).FirstOrDefault();
            //        Walls.Remove(targetWall);
            //    }
            //}

            //player.Position = new Vector2(startPos.X + (16 * (width / 2) - (player.Width / 2)),
            //    startPos.Y + (16 * (height / 2)) - (player.Height / 2));
        }

        private void CollisionChecks()
        {
            //Rectangle PlayerHitMask_Body = player.Rectangle;
            //for(int i = 0; i < Walls.Count; i ++)
            //{
            //    Wall wall = Walls[i];
            //    Rectangle wallHitBox = new Rectangle((int)wall.Position.X, (int)wall.Position.Y, wall.Width, wall.Height);
            //    if (wallHitBox.Intersects(PlayerHitMask_Body))
            //    {
            //        Walls.RemoveAt(i);
            //    }
            //}
        }
    }
}
