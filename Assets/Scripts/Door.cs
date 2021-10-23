using UnityEngine;
namespace Core
{
    public sealed class Door
    {
        private bool _isOpen;
        private Animator _animator;

        public void DoorAction(GameObject triggerObject, PlayerData playerData, string actionType)
        {
            bool check;
            if (triggerObject.name == "BlueDoor" && playerData.BlueKey == true)
            {
                check = true;
            }
            else if (triggerObject.name == "RedDoor" && playerData.RedKey == true)
            {
                check = true;
            }
            else if (triggerObject.name == "YellowDoor" && playerData.YellowKey == true)
            {
                check = true;
            }
            else
            { 
                check = false; 
            }
            if (actionType == "Open" && check == true)
            {
                OnDoorOpen(triggerObject, playerData);
            }
            else if (actionType == "Close" && check == true)
            {
                OnDoorClose(triggerObject, playerData);
            }

        }
        void OnDoorOpen(GameObject triggerObject, PlayerData playerData)
        {
            _animator = triggerObject.GetComponentInChildren<Animator>();
            _isOpen = true;
            _animator.SetBool("IsOpen", _isOpen);
        }

        void OnDoorClose(GameObject triggerObject, PlayerData playerData)
        {
            _animator = triggerObject.GetComponentInChildren<Animator>();
            _isOpen = false;
            _animator.SetBool("IsOpen", _isOpen);
        }
    }
}
