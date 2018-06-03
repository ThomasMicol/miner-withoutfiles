using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MinerGame.Drills;

namespace MinerGame
{
    public class RigComponentController
    {
        protected List<RigComponent> ComponentList = new List<RigComponent>();
        protected Drill Drill;
        protected Hull Hull;
        protected Tracks Tracks;
        protected Cargo Cargo;
        protected FuelTank FuelTank;
        protected Radiator Radiator;
        protected Engine Engine;
        protected FlashLight FlashLight;
        protected Battery Battery;

        #region Getters & Setters
        public void SetDrill(Drill aDrill)
        {
            ReplaceComponent(Drill, aDrill);
            Drill = aDrill;
        }

        public void SetHull(Hull aHull)
        {
            ReplaceComponent(Hull, aHull);
            Hull = aHull;
        }

        public void SetTracks(Tracks aTracks)
        {
            ReplaceComponent(Tracks, aTracks);
            Tracks = aTracks;
        }

        public void SetCargo(Cargo aCargo)
        {
            ReplaceComponent(Cargo, aCargo);
            Cargo = aCargo;
        }

        public void SetFuelTank(FuelTank aFuelTank)
        {
            ReplaceComponent(FuelTank, aFuelTank);
            FuelTank = aFuelTank;
        }

        public void SetFan(Radiator aRadiator)
        {
            ReplaceComponent(Radiator, aRadiator);
            Radiator = aRadiator;
        }

        public void SetEngine(Engine aEngine)
        {
            ReplaceComponent(Engine, aEngine);
            Engine = aEngine;
        }

        public void SetFlashLight(FlashLight aFlashLight)
        {
            ReplaceComponent(FlashLight, aFlashLight);
            FlashLight = aFlashLight;
        }

        public void SetBattery(Battery aBattery)
        {
            ReplaceComponent(Battery, aBattery);
            Battery = aBattery;
        }

        public Drill GetDrill() { return Drill; }
        public Hull GetHull() { return Hull; }
        public Tracks GetTracks() { return Tracks; }
        public Cargo GetCargo() { return Cargo; }
        public FuelTank GetFuelTank() { return FuelTank; }
        public Radiator GetFan() { return Radiator; }
        public Engine GetEngine() { return Engine; }
        public FlashLight GetFlashLight() { return FlashLight; }
        public Battery GetBattery() { return Battery; }
        #endregion

        protected void ReplaceComponent(RigComponent oldComponent, RigComponent newComponent)
        {
            int replaceIndex = ComponentList.IndexOf(oldComponent);
            if(replaceIndex != -1)
            {
                ComponentList.RemoveAt(replaceIndex);
            }
            ComponentList.Add(newComponent);
        }

        internal void DrawComponents(GameTime aTime, SpriteBatch batch, Vector2 aRigLocation)
        {
            foreach(RigComponent aComp in ComponentList)
            {
                aComp.SetRigLocation(aRigLocation);
                aComp.Draw(aTime, batch);
            }
        }
    }
}