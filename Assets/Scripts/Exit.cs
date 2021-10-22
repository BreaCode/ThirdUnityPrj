using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public sealed class Exit : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private int _sceneNumber;

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
            if (other == _player.GetComponentInChildren<SphereCollider>())
            {
                Debug.Log("Exit");
                if (_sceneNumber != 1)
                {
                    SceneManager.LoadScene(_sceneNumber + 1);
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
