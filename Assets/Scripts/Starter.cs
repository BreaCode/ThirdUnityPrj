using UnityEngine;

namespace Core
{
    public sealed class Starter : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _playerData;
        private Controllers _controllers;


        void Start()
        {
            DataInitializator.InitializeData(_playerData);
            _controllers = new Controllers();
            new GameInitialization(_controllers, _playerData);
            _controllers.Initialization();
            Cursor.lockState = CursorLockMode.Locked;
        }
        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers.LateExecute(deltaTime);
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}

