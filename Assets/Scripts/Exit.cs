using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public sealed class Exit
    {
        private PlayerData _playerData;
        private int _sceneNumber;


        public Exit(PlayerData playerData)
        {
            _playerData = playerData;
            _sceneNumber = playerData.SceneNumber;
        }

        internal void Action()
        {
            if (_playerData.Score * 2 >= _playerData.MaxScore)
            {
                if (_sceneNumber != 1)
                {
                    SceneManager.LoadScene(_sceneNumber + 1);
                    DataInitializator.InitializePalyerData(_playerData);
                }
                else
                {
                    GameEventSystem.current.Win();
                    //Close();
                }
            }
        }
        private void Close()
        {
            Application.Quit();
        }
    }
}
