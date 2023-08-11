using UnityEngine;

namespace Outgame
{
    public class ScreenPresenterBase : MonoBehaviour
    {
        public void Start()
        {
            Initialize();
        }

        protected virtual void Initialize()
        {
        }
    }
}