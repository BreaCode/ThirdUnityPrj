using UnityEngine;
namespace Core
{
    public sealed class Player : MonoBehaviour
    {
        //Здесь пока колхоз
        private GameObject _menu;

        public GameObject Menu
        {
            get { return _menu; }
        }
        private void Start()
        {
            //Я знаю что так нельзя, но сделал просто чтоб работало пока я пытаюсь понять как правильно
            _menu = GameObject.Find("PauseMenu");
            _menu.SetActive(false);
        }
        void Update()
        {
            if (Input.GetButtonDown("Pause"))
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
                _menu.SetActive(true);
                gameObject.GetComponent<Player>().enabled = !gameObject.GetComponent<Player>().enabled;
            }
        }


    }
}