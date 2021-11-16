using UnityEngine;

namespace Core
{
    public sealed class Trigger : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _playerData;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == _playerData.PlayerObject)
            {
                TriggerAction action = new TriggerAction();
                action.Action(gameObject, _playerData, ActionsManager.ENTER);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject == _playerData.PlayerObject)
            {
                TriggerAction action = new TriggerAction();
                action.Action(gameObject, _playerData, ActionsManager.EXIT);
            }
        }
    }
}

