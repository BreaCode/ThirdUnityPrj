using UnityEngine;

namespace Core
{
    public class Trigger : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _playerData;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == _playerData.PlayerObject)
            {
                TriggerAction action = new TriggerAction();
                action.Action(gameObject, _playerData, "Enter");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject == _playerData.PlayerObject)
            {
                TriggerAction action = new TriggerAction();
                action.Action(gameObject, _playerData, "Exit");
            }
        }

    }
}

