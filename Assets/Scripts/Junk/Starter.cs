using UnityEngine;

namespace JunkYard
{
    public class Starter : MonoBehaviour
    {
        #region Fields
        private GameObject _fixedCamera;
        private GameObject _fromAboveCamera;
        private GameObject _player;
        private Component _playerRigidBody;
        private GameObject _blueKey;
        private GameObject _redKey;
        private GameObject _yellowKey;
        private GameObject _blueDoor;
        private GameObject _redDoor;
        private GameObject _yellowDoor;
        #endregion

        #region Properties
        public GameObject FixedCamera
        {
            get { return _fixedCamera; }
        }
        public GameObject FromAboveCamera
        {
            get { return _fromAboveCamera; }
        }
        public GameObject PlayerObject
        {
            get { return _player; }
        }
        public Component PlayerRigidBody
        {
            get { return _playerRigidBody; }
        }
        public GameObject BlueKey
        {
            get { return _blueKey; }
        }
        public GameObject RedKey
        {
            get { return _redKey; }
        }
        public GameObject YellowKey
        {
            get { return _yellowKey; }
        }
        public GameObject BlueDoor
        {
            get { return _blueDoor; }
        }
        public GameObject RedDoor
        {
            get { return _redDoor; }
        }
        public GameObject YellowDoor
        {
            get { return _yellowDoor; }
        }
        #endregion

        void Awake()
        {
            GameObject[] findObject = GameObject.FindGameObjectsWithTag("MainCamera");
            if (findObject[0] != null && findObject[1] != null)
            {
                _fixedCamera = findObject[0];
                _fromAboveCamera = findObject[1];
            }
            else
            {
                Debug.Log("Camera not found");
            }
            _fixedCamera.SetActive(false);
            GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
            if (player[0] != null)
            {
                _player = player[0];
                _playerRigidBody = _player.GetComponent<Rigidbody>();
            }
            else
            {
                Debug.Log("Player not found");
            }
            _blueKey = GameObject.Find("BlueKey");
            _blueDoor = GameObject.Find("BlueDoor");
            _redKey = GameObject.Find("RedKey");
            _redDoor = GameObject.Find("RedDoor");
            _yellowKey = GameObject.Find("YellowKey");
            _yellowDoor = GameObject.Find("YellowDoor");

            //Debug.Log(_fixedCamera.name + " " + _fromAboveCamera.name);
            //Debug.Log(_player.name)
        }

    }
}
