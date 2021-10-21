using UnityEngine;
namespace Core
{
    public sealed class Player : MonoBehaviour
    {
        private Transform _cameraTransform;
        private Rigidbody _playerRigidBody;
        private Transform _playerTransform;
        private Vector3 _direction;
        private float _speed = 10;
        private void Start()
        {
            _cameraTransform = gameObject.transform.GetChild(1);
            _playerRigidBody = gameObject.GetComponentInChildren<Rigidbody>();
            _playerTransform = gameObject.transform.GetChild(0);
        }
        void Update()
        {
            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");
            Move();
        }

        private void Move()
        {
            _playerRigidBody.AddForce(_direction * _speed);
            _cameraTransform.position = new Vector3(_playerTransform.position.x, 7, _playerTransform.position.z);
        }
    }
}