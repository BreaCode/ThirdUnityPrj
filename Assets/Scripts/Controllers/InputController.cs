namespace UserInput
{
    public sealed class InputController : Core.IExecute
    {
        private IInput _horizontal;
        private IInput _vertical;

        public InputController((IInput inputHorizontal, IInput inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
            Core.GameEventSystem.current.onControlUpdate += UpdateInput;
        }

        private void UpdateInput(string controlType)
        {
            if (controlType == "Mouse")
            {
                _horizontal = new PCInputMouseX();
                _vertical = new PCInputMouseY();
            }
            else
            {
                _horizontal = new PCInputHorizontal();
                _vertical = new PCInputVertical();
            }
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }

        ~InputController()
        {
            Core.GameEventSystem.current.onControlUpdate -= UpdateInput;
        }
    }
}