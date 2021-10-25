using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public sealed class Exit
    {
        [SerializeField] private GameObject _player;
        private int _sceneNumber;

        public Exit(PlayerData playerData)
        {
            _sceneNumber = playerData.SceneNumber;
        }

        internal void Action()
        {
            if (_sceneNumber != 1)
            {
                SceneManager.LoadScene(_sceneNumber + 1);
            }
            else
            {
                Close();
            }
        }
        private void Close()
        {
            Application.Quit();
        }
    }
}
