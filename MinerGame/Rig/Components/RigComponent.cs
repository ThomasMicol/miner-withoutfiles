using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MinerGame
{
    public class RigComponent : Sprite
    {
        protected Vector2 RigPosition = new Vector2(0,0);
        protected Vector2 ComponentOffset = new Vector2(0, 0);
        protected float PowerUsage;
        protected float HeatGenerated;
        protected float Weight;
        protected float FuelUsage;
        protected string Name;
        protected string Description;

        #region Getters & Setters
        public float GetPowerUsage() { return PowerUsage; }
        public float GetHeatGenerated() { return HeatGenerated; }
        public float GetWeight() { return Weight; }
        public float GetFuelUsage() { return FuelUsage; }
        public string GetName() { return Name; }
        public string GetDescription() { return Description; }
        public void SetPowerUsage(float aPowerUsage) { PowerUsage = aPowerUsage; }
        public void SetHeatGenerated(float aHeatGenerated) { HeatGenerated = aHeatGenerated; }
        public void SetWeight(float aWeight) { Weight = aWeight; }
        public void SetFuelUsage(float aFuelUsage) { FuelUsage = aFuelUsage; }
        public void SetName(string name) { Name = name; }
        public void SetDescription(string description) { Description = description; }
        public void SetRigPosition(Vector2 aLoc){ RigPosition = aLoc; }
        #endregion

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Texture == null)
            {
                return;
            }
            else
            {
                spriteBatch.Draw(Texture,
                RigPosition + ComponentOffset,
                null,
                Color.White,
                0f,
                Vector2.Zero,
                1f,
                SpriteEffects.None, 0f);
            }
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}