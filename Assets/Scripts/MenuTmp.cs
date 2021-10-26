using UnityEngine;

namespace Core
{
    public class MenuTmp : MonoBehaviour
    {
        //Здесь пока колхоз
        private GameObject _menu;
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
            }
        }
        public void Continue()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            _menu.SetActive(false);
        }
        public void Close()
        {
            Application.Quit();
        }
    }
}
