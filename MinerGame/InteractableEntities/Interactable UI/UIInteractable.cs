namespace MinerGame.Buildings
{
    public abstract class UIInteractable
    {
        protected Interactable CallingInteractable;

        public UIInteractable(object callingInteractable)
        {
            CallingInteractable = (Interactable)callingInteractable;
        }

        public abstract void Draw();
    }
}