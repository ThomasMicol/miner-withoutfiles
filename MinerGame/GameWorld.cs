using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MinerGame
{
    class GameWorld
    {
        protected Game1 MyGame;
        public Rig Player;
        protected Cursor cursor; 

        public GameWorld(Game1 game)
        {
            MyGame = game;
            Player = new Rig(MyGame.Content.Load<Texture2D>("sprites/sHull_Base"));
            Player.Position = new Vector2((Game1.ScreenWidth / 2) - (Player.Width / 2),
                (Game1.ScreenHeight / 2) - (Player.Height / 2));
            cursor = new Cursor();
        }


    }
}