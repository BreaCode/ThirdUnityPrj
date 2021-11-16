using UnityEngine;

namespace Core
{
    public sealed class TriggerAction
    {
        // Это надо будет переделать
        public void Action(GameObject triggerObject, PlayerData playerData, string actiontype)
        {
            if (actiontype == ActionsManager.ENTER)
            {
                EnterAction(triggerObject, playerData);
            }
            else if (actiontype == ActionsManager.EXIT)
            {
                ExitAction(triggerObject, playerData);
            }
        }
        void EnterAction(GameObject triggerObject, PlayerData playerData)
        {
            if (triggerObject.CompareTag(TagsManager.COIN))
            {
                Coin coin = new Coin();
                coin.PickUp(triggerObject, playerData);
            }
            else if (triggerObject.CompareTag(TagsManager.DOOR))
            {
                Door door = new Door();
                door.DoorAction(triggerObject, playerData, ActionsManager.OPEN);
            }
            else if (triggerObject.CompareTag(TagsManager.KEY))
            {
                Key key = new Key();
                key.PickUp(triggerObject, playerData);
            }
            else if (triggerObject.CompareTag(TagsManager.EXIT))
            {
                Exit exit = new Exit(playerData);
                exit.Action();
            }
        }
        void ExitAction(GameObject triggerObject, PlayerData playerData)
        {
            if (triggerObject.CompareTag(TagsManager.DOOR))
            {
                Door door = new Door();
                door.DoorAction(triggerObject, playerData, ActionsManager.CLOSE);
            }
        }
    }
}

