namespace UserInput
{
    public sealed class InputController : Core.IExecute
    {
        private readonly IInput _horizontal;
        private readonly IInput _vertical;

        public InputController((IInput inputHorizontal, IInput inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }
}