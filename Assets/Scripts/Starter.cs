using UnityEngine;

namespace Core
{
    public sealed class Starter : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _playerData;
        
        void Start()
        {
            DataInitializator.InitializeData(_playerData);
            Cursor.lockState = CursorLockMode.Locked;
        }

    }
}

