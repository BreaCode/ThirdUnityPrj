using UnityEngine;
namespace Core
{
    public sealed class Player : MonoBehaviour
    {
        //����� ���� ������
        private GameObject _menu;

        public GameObject Menu
        {
            get { return _menu; }
        }
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
                gameObject.GetComponent<Player>().enabled = !gameObject.GetComponent<Player>().enabled;
            }
        }


    }
}