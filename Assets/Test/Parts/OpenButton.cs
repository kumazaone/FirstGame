using UnityEngine;

namespace Outgame
{
    public class OpenButton : UiPartsBase
    {
        private OutgameManager _outgameManager;
        public OutgameScreen _screen;

        public void OnClick()
        {
            OutgameManager.Instance.Open(_screen);
        }
    }
}