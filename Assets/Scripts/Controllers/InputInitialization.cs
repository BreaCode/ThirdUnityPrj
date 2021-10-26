namespace UserInput
{
    internal sealed class InputInitialization : Core.IInitialization
    {
        private IInput _pcInputHorizontal;
        private IInput _pcInputVertical;
        private string _controlType;

        public InputInitialization(Core.PlayerData playerData)
        {
            _controlType = playerData.ControlType;
            Initialization();
        }

        public void Initialization()
        {
            if (_controlType == "Mouse")
            {
                _pcInputHorizontal = new PCInputMouseX();
                _pcInputVertical = new PCInputMouseY();
            }
            else
            {
                _pcInputHorizontal = new PCInputHorizontal();
                _pcInputVertical = new PCInputVertical();
            }
        }

        public (IInput inputHorizontal, IInput inputVertical) GetInput()
        {
            (IInput inputHorizontal, IInput inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }
    }
}
