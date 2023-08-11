namespace Outgame
{
    public class CloseButton : UiPartsBase
    {
        public void Close()
        {
            OutgameManager.Instance.Close();
        }
    }
}