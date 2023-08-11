using UnityEngine;

namespace Outgame
{
    public class TitleScreenPresenter : ScreenPresenterBase
    {
        [SerializeField] private TitleScreenView _screenView;
        [SerializeField] private TitleScreenModel _screenModel;

        private string _test;

        protected override void Initialize()
        {
            Debug.Log("タイトル");

            _test = _screenModel.GetTest();
            
            _screenView.Setup(_test);
        }
    }
}