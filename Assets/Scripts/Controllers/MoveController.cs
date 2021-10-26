using UnityEngine;

namespace Core
{
    public sealed class MoveController : IExecute, ICleanup
    {
        private readonly Transform _player;
        private readonly Transform _camera;
        private readonly PlayerData _playerData;
        private Rigidbody _playerRigidBody;
        private float _speed;
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
            _speed = _playerData.Speed;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        public void Execute(float deltaTime)
        {
            //var speed = deltaTime * _playerData.Speed;
            //_move.Set(_horizontal * speed, _vertical * speed, 0.0f);
            //_player.localPosition += _move;
            _direction.x = _horizontal;
            _direction.z = _vertical;
            _playerRigidBody.AddForce(_direction * _speed);
            _camera.position = new Vector3(_player.position.x, 7, _player.position.z);

        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
        }
    }
}
