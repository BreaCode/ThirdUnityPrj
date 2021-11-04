using UnityEngine;

namespace Core
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, PlayerData data)
        {
            Camera camera = Camera.main;
            var inputInitialization = new UserInput.InputInitialization(data);
            var giuInitialization = new GUIController(data);
            controllers.Add(giuInitialization);
            controllers.Add(inputInitialization);
            controllers.Add(new UserInput.InputController(inputInitialization.GetInput()));
            controllers.Add(new MoveController(inputInitialization.GetInput(), data.PlayerObject.transform, data));
        }
    }
}
