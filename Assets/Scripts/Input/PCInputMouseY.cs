using System;
using UnityEngine;

namespace UserInput
{
    public sealed class PCInputMouseY : IInput
    {
        public event Action<float> AxisOnChange = delegate (float f) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(InputManager.MOUSEY));
        }
    }
}
