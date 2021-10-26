namespace Core
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}