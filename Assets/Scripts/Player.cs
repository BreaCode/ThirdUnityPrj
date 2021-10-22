using UnityEngine;
namespace Core
{
    public sealed class Player : MonoBehaviour
    {
        //Здесь пока колхоз
        private Transform _cameraTransform;
        private Rigidbody _playerRigidBody;
        private Transform _playerTransform;
        private Vector3 _direction;
        private float _speed = 10;
        private GameObject _menu;

        public GameObject Menu
        {
            get { return _menu; }
        }
        private void Start()
        {
            //Я знаю что так нельзя, но сделал просто чтоб работало пока я пытаюсь понять как правильно
            _menu = GameObject.Find("PauseMenu");
            _cameraTransform = gameObject.transform.GetChild(1);
            _playerRigidBody = gameObject.GetComponentInChildren<Rigidbody>();
            _playerTransform = gameObject.transform.GetChild(0);
            _menu.SetActive(false);
        }
        void Update()
        {
            //_direction.x = Input.GetAxis("Horizontal");
            //_direction.z = Input.GetAxis("Vertical");
            _direction.x = Input.GetAxis("Mouse X");
            _direction.z = Input.GetAxis("Mouse Y");
            Move();
            if (Input.GetButtonDown("Pause"))
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
                _menu.SetActive(true);
                gameObject.GetComponent<Player>().enabled = !gameObject.GetComponent<Player>().enabled;
            }
        }

        private void Move()
        {
            _playerRigidBody.AddForce(_direction * _speed);
            _cameraTransform.position = new Vector3(_playerTransform.position.x, 7, _playerTransform.position.z);
        }
    }
}