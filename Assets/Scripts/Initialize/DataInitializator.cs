using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public sealed class DataInitializator
    {
        private static PlayerData _playerData;
        private static Data _data;
        
        public static void InitializePalyerData(PlayerData playerData)
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

            _playerData.Score = 0;
            //Временная мера
            GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
            //
            _playerData.MaxScore = coins.Length;

            if (_playerData.Speed == 0)
            {
                _playerData.Speed = 50;
            }
            //Debug.Log(_playerData.Camera + " " + _playerData.PlayerObject + " " + _playerData.Speed);
        }
        public static void InitializeData(Data data)
        {
            _data = data;
            _data.Coins = GameObject.FindGameObjectsWithTag("Coin");
            _data.Traps = GameObject.FindGameObjectsWithTag("Trap");
            _data.Keys = GameObject.FindGameObjectsWithTag("Key");
            _data.Doors = GameObject.FindGameObjectsWithTag("Door");
            _data.Exit = GameObject.FindGameObjectWithTag("Exit");
            _data.GUI = GameObject.Find("GUI");
            _data.DefaultMode = "Normal";
            _data.SceneNumber = SceneManager.GetActiveScene().buildIndex;
        }

    }
}

