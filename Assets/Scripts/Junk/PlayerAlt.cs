using UnityEngine;
namespace JunkYard
{
    public class Player : MonoBehaviour
    {
        private Rigidbody _playerRigidBody;
        private Vector3 _direction;
        private float _speed = 10;
        private void Start()
        {
            _playerRigidBody = gameObject.GetComponent<Rigidbody>();
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
        }
    }
}