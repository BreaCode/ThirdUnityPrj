using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public sealed class DataInitializator
    {
        private static PlayerData _playerData;
        public static void InitializeData(PlayerData playerData)
        {
            _playerData = playerData;
            _playerData.Cameras = GameObject.FindGameObjectsWithTag("MainCamera");
            _playerData.PlayerObject = GameObject.Find("PlayerObject");
            _playerData.Camera = _playerData.Cameras[0];
            _playerData.ControlType = "Mouse";
            _playerData.SceneNumber = SceneManager.GetActiveScene().buildIndex;
            _playerData.CameraHeight = 6;

            _playerData.BlueKey = false;
            _playerData.RedKey = false;
            _playerData.YellowKey = false;

            if (_playerData.Speed == 0)
            {
                _playerData.Speed = 10;
            }
            //Debug.Log(_playerData.Camera + " " + _playerData.PlayerObject + " " + _playerData.Speed);
        }
    }
}

