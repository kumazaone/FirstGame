using UnityEngine;

namespace Outgame
{
    public class TitleScreenView : ScreenViewBase
    {
        public void Setup(string test)
        {
            Debug.Log($"Viewから発信{test}");
        }
    }
}