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
            Drill = (Drill)ReplaceComponent(Drill, aDrill);
        }

        public void SetHull(Hull aHull)
        {
            Hull = (Hull)ReplaceComponent(Hull, aHull);
        }

        public void SetTracks(Tracks aTracks)
        {
            Tracks = (Tracks)ReplaceComponent(Tracks, aTracks);
        }

        public void SetCargo(Cargo aCargo)
        {
            Cargo = (Cargo)ReplaceComponent(Cargo, aCargo);
        }

        public void SetFuelTank(FuelTank aFuelTank)
        {
            FuelTank = (FuelTank)ReplaceComponent(FuelTank, aFuelTank);
        }

        public void SetFan(Radiator aRadiator)
        {
            Radiator = (Radiator)ReplaceComponent(Radiator, aRadiator);
        }

        public void SetEngine(Engine aEngine)
        {
            Engine = (Engine)ReplaceComponent(Engine, aEngine);
        }

        public void SetFlashLight(FlashLight aFlashLight)
        {
            FlashLight = (FlashLight)ReplaceComponent(FlashLight, aFlashLight);
        }

        public void SetBattery(Battery aBattery)
        {
            Battery = (Battery)ReplaceComponent(Battery, aBattery);
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

        protected RigComponent ReplaceComponent(RigComponent oldComponent, RigComponent newComponent)
        {
            int replaceIndex = ComponentList.IndexOf(oldComponent);
            if(replaceIndex != -1)
            {
                ComponentList.RemoveAt(replaceIndex);
            }
            ComponentList.Add(newComponent);

            return newComponent;
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