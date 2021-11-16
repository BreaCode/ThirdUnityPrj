using System;
using UnityEngine;

namespace Core
{
    public sealed class GameEventSystem : MonoBehaviour
    {
        public static GameEventSystem current;

        void Awake()
        {
            current = this;
        }

        public event Action onWin;
        public void Win()
        {
            if (onWin != null)
            {
                onWin();
            }
        }
        public event Action onScoreUpdate;
        public void ScoreUpdate()
        {
            if (onScoreUpdate != null)
            {
                onScoreUpdate();
            }
        }
        public event Action onKeyUpdate;
        public void KeyUpdate()
        {
            if (onKeyUpdate != null)
            {
                onKeyUpdate();
            }
        }
        public event Action onSpeedUpdate;
        public void SpeedUpdate()
        {
            if (onSpeedUpdate != null)
            {
                onSpeedUpdate();
            }
        }
        public event Action<string> onControlUpdate;
        public void ControlUpdate(string controlType)
        {
            if (onControlUpdate != null)
            {
                onControlUpdate(controlType);
            }
        }
    }
}

