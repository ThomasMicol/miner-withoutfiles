namespace MinerGame.Buildings
{
    public abstract class Interactable : Sprite
    {
        protected UIInteractable myUI;
        public abstract void Interact();
    }
}