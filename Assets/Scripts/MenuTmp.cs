using UnityEngine;

namespace Core
{
    public class MenuTmp : MonoBehaviour
    {
        //����� ���� ������
        private GameObject _menu;
        private void Start()
        {
            //� ���� ��� ��� ������, �� ������ ������ ���� �������� ���� � ������� ������ ��� ���������
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
