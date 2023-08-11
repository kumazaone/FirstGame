using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Outgame
{
    public class EntryPoint : MonoBehaviour
    {
        void Start()
        {
            _DelayAsync().Forget();
        }

        private async UniTask _DelayAsync()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(3));

            Debug.Log("よろしくね");
        }
    }
}