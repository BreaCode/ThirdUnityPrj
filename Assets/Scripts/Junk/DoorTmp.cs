using UnityEngine;
namespace Core
{
    //Временный класс
    public sealed class DoorTmp : MonoBehaviour
    {
        private GameObject _player;
        private Animator _animator;
        private bool _isOpen;
        private void Awake()
        {
            _player = GameObject.Find("PlayerObject");
            _animator = gameObject.GetComponentInChildren<Animator>();
        }

        private void OnDoorOpen()
        {
            _isOpen = true;
            _animator.SetBool("IsOpen", _isOpen);
        }

        private void OnDoorClose()
        {
            _isOpen = false;
            _animator.SetBool("IsOpen", _isOpen);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == _player.name)
            {
                OnDoorOpen();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == _player.name)
            {
                OnDoorClose();
            }
        }
    }
}
