using System;
using UnityEngine;

namespace Core
{
    public sealed class GameEventSystem : MonoBehaviour
    {
        //Это синглтон и так нельзя? Какая алтернатива?
        public static GameEventSystem current;

        void Awake()
        {
            current = this;
        }

        public event Action onToggle;
        public void toggle()
        {
            if (onToggle != null)
            {
                onToggle();
            }
        }
        public event Action onScoreUpdate;
        public void scoreUpdate()
        {
            if (onScoreUpdate != null)
            {
                onScoreUpdate();
            }
        }
        public event Action onKeyUpdate;
        public void keyUpdate()
        {
            if (onKeyUpdate != null)
            {
                onKeyUpdate();
            }
        }
        public event Action onSpeedUpdate;
        public void speedUpdate()
        {
            if (onSpeedUpdate != null)
            {
                onSpeedUpdate();
            }
        }
        public event Action<string> onControlUpdate;
        public void controlUpdate(string controlType)
        {
            if (onControlUpdate != null)
            {
                onControlUpdate(controlType);
            }
        }
    }
}

