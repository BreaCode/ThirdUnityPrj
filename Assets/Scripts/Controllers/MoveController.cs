using UnityEngine;

namespace Core
{
    public sealed class MoveController : IFixed, ICleanup
    {
        private readonly Transform _player;
        private readonly Transform _camera;
        private readonly PlayerData _playerData;
        private Rigidbody _playerRigidBody;
        private float _speed;
        private float _height;
        private float _horizontal;
        private float _vertical;
        private Vector3 _direction;
        private UserInput.IInput _horizontalInputProxy;
        private UserInput.IInput _verticalInputProxy;

        public MoveController((UserInput.IInput inputHorizontal, UserInput.IInput inputVertical) input,
            Transform player, PlayerData playerData)
        {
            _player = player;
            _playerData = playerData;
            _camera = _playerData.Camera.transform;
            _playerRigidBody = _playerData.PlayerObject.GetComponent<Rigidbody>();
            _height = _playerData.CameraHeight;
            _speed = _playerData.Speed;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
            GameEventSystem.current.onSpeedUpdate += UpdateSpeed;
        }
        private void UpdateSpeed()
        {
            _speed = _playerData.Speed;
        }
        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        public void Fixed(float deltaTime)
        {
            _direction.x = _horizontal;
            _direction.z = _vertical;
            _playerRigidBody.AddForce(_direction * _speed);
            _camera.position = new Vector3(_player.position.x, _height, _player.position.z);
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
        }
        ~MoveController()
        {
            GameEventSystem.current.onSpeedUpdate -= UpdateSpeed;
        }
    }
}
