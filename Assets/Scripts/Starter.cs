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


        //Сделал это тут пока. Просто что не вешать лишние скрипты
        public void Continue()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            _playerData.PlayerObject.GetComponentInParent<Player>().enabled = !_playerData.PlayerObject.GetComponentInParent<Player>().enabled;
            _playerData.PlayerObject.GetComponentInParent<Player>().Menu.SetActive(false);
        }
        public void Close()
        {
            Application.Quit();
        }
    }
}

