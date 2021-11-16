using UnityEngine;
namespace Core
{
    public sealed class Key
    {
        public void PickUp(GameObject triggerObject, PlayerData playerData)
        {
            if (triggerObject.name == "BlueKey")
            {
                playerData.BlueKey = true;
            }
            else if (triggerObject.name == "RedKey")
            {
                playerData.RedKey = true;
            }
            else if (triggerObject.name == "YellowKey")
            {
                playerData.YellowKey = true;
            }
            
            triggerObject.SetActive(false);
            GameEventSystem.current.KeyUpdate();
        }
    }
}

