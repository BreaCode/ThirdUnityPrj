using UnityEngine;

namespace Core
{
    public class TriggerAction
    {
        // Это надо будет переделать
        public void Action(GameObject triggerObject, PlayerData playerData, string actiontype)
        {
            if (actiontype == "Enter")
            {
                EnterAction(triggerObject, playerData, triggerObject.tag);
            }
            else if (actiontype == "Exit")
            {
                ExitAction(triggerObject, playerData, triggerObject.tag);
            }
        }
        void EnterAction(GameObject triggerObject, PlayerData playerData, string tag)
        {
            if (tag == "Door")
            {
                Door door = new Door();
                door.DoorAction(triggerObject, playerData,"Open");
            }
            else if (tag == "Key")
            {
                Key key = new Key();
                key.PickUp(triggerObject, playerData);
            }
        }
        void ExitAction(GameObject triggerObject, PlayerData playerData, string tag)
        {
            if (tag == "Door")
            {
                Door door = new Door();
                door.DoorAction(triggerObject, playerData, "Close");
            }
        }
    }
}

