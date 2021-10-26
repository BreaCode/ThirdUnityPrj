namespace Core
{
    public interface IExecute : IController
    {
        void Execute(float deltaTime);
    }
}