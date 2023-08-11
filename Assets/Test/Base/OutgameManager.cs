using System.Collections.Generic;
using UnityEngine;

namespace Outgame
{
    public enum OutgameScreen
    {
        Bg,
        Title,
        Home,
        Max
    }

    public class OutgameManager : MonoBehaviour
    {
        [SerializeField] private Transform _parent;

        /// <summary>
        /// Screenを追加するときにはここに追加してね
        /// enumに入れるのも忘れずに
        /// </summary>
        [SerializeField] private BgScreenPresenter _bgScreenPresenter;
        [SerializeField] private HomeScreenPresenter _homeScreenPresenter;
        [SerializeField] private TitleScreenPresenter _titleScreenPresenter;

        public static OutgameManager Instance;
        private List<ScreenPresenterBase> _screenList;
        private int _screenIndex;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void Start()
        {
            _screenList = new((int)OutgameScreen.Max);
            _screenList.Add(_bgScreenPresenter);
        }

        /// <summary>
        /// Screenの追加
        /// </summary>
        public void Open(OutgameScreen screen)
        {
            ScreenPresenterBase newScreen = _CreateScreen(screen);
            _screenList.Add(newScreen);
            _screenIndex++;
        }

        /// <summary>
        /// 一番手前のScreenを削除
        /// </summary>
        public void Close()
        {
            Destroy(_screenList[_screenIndex].gameObject);
            _screenList.RemoveAt(_screenIndex);
            _screenIndex--;
        }

        /// <summary>
        /// 一番手前のScreenと入れ替えて表示
        /// </summary>
        public void ChangeScreen(OutgameScreen screen)
        {
            ScreenPresenterBase newScreen = _CreateScreen(screen);
            _screenList.Add(newScreen);

            // Screenを作成してから削除
            Destroy(_screenList[_screenIndex].gameObject);
            _screenList.RemoveAt(_screenIndex);
        }

        /// <summary>
        /// ScreenTypeからScreenを作成
        /// </summary>
        private ScreenPresenterBase _CreateScreen(OutgameScreen screen)
        {
            ScreenPresenterBase newScreen = new();

            switch (screen)
            {
                case OutgameScreen.Title:
                    newScreen = Instantiate(_titleScreenPresenter, _parent);
                    break;

                case OutgameScreen.Home:
                    newScreen = Instantiate(_homeScreenPresenter, _parent);
                    break;
            }

            return newScreen;
        }
    }
}