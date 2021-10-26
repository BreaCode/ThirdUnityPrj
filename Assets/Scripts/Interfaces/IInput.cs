using System;
namespace UserInput
{
    public interface IInput
    {
        event Action<float> AxisOnChange;
        void GetAxis();
    }
}
