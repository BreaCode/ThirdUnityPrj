using UnityEngine;

namespace Core
{
    public sealed class Exit : MonoBehaviour
    {
        [SerializeField] private GameObject _player;

        public void Close()
        {
            Application.Quit();
        }
        //Сделал это тут пока. Просто что не вешать лишние скрипты
        public void Continue()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            _player.GetComponent<Player>().enabled = !_player.GetComponent<Player>().enabled;
            _player.GetComponent<Player>().Menu.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == _player.name)
            {
                Close();
            }
        }
    }
}
