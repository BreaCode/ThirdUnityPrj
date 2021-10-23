using UnityEngine;
namespace Core
{
    public class DataInitializator : MonoBehaviour
    {
        private static PlayerData _playerData;
        public static void InitializeData(PlayerData playerData)
        {
            _playerData = playerData;
            _playerData.Cameras = GameObject.FindGameObjectsWithTag("MainCamera");
            _playerData.PlayerObject = GameObject.Find("PlayerObject");
            _playerData.Camera = _playerData.Cameras[0];
            _playerData.Speed = 10;
            _playerData.BlueKey= false;
            _playerData.RedKey = false;
            _playerData.YellowKey = false;
            //Debug.Log(_playerData.Camera + " " + _playerData.PlayerObject + " " + _playerData.Speed);
        }
    }
}

