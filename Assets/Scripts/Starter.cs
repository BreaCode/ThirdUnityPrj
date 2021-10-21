using UnityEngine;

namespace Core
{
    public class Starter : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _playerData;
        void Start()
        {
            DataInitializator.InitializeData(_playerData);
        }

    }
}

