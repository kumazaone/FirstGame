namespace Outgame
{
    public class ChangeButton : UiPartsBase
    {
        public OutgameScreen _screen;
        
        public void ChangeScreen()
        {
            OutgameManager.Instance.ChangeScreen(_screen);
        }
    }
}