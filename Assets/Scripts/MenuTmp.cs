using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Core
{
    public sealed class MenuTmp : MonoBehaviour
    {
        //Здесь пока колхоз
        private GameObject _menu;
        private GameObject _settings;
        private GameObject _gui;
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _quitButton;
        [SerializeField] private Button _returnButton;
        [SerializeField] private Slider _speedSlider;
        [SerializeField] private TMP_Dropdown _controlType;
        [SerializeField] private PlayerData _playerData;
        

        private void Start()
        {
            //Я знаю что так нельзя, но сделал просто чтоб работало пока я пытаюсь понять как правильно
            _menu = GameObject.Find("PauseMenu");
            _settings = GameObject.Find("SettingsMenu");
            _gui = GameObject.Find("GUI");
            _continueButton.onClick.AddListener(Continue);
            _settingsButton.onClick.AddListener(SettingsOpen);
            _quitButton.onClick.AddListener(Close);
            _returnButton.onClick.AddListener(Return);
            _speedSlider.onValueChanged.AddListener((float value) => { SetSpeed(value); });
            _controlType.onValueChanged.AddListener(delegate { ControlChanged (_controlType);});
            _settings.SetActive(false);
            _menu.SetActive(false);
            _gui.SetActive(false);
        }
        void Update()
        {
            if (Input.GetButtonDown("Pause"))
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
                _settings.SetActive(false);
                _menu.SetActive(true);
            }
        }

        private void SettingsOpen()
        {
            _menu.SetActive(false);
            _settings.SetActive(true);
        }
        private void Return()
        {
            _settings.SetActive(false);
            _menu.SetActive(true);
        }
        private void Continue()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            _menu.SetActive(false);
        }
        private void Close()
        {
            Application.Quit();
        }

        private void SetSpeed(float speed)
        {
            _playerData.Speed = speed;
        }

        private void ControlChanged(TMP_Dropdown _controlType)
        {
            //Тут ошибка
            _playerData.ControlType = _controlType.itemText.ToString();
            //UserInput.InputInitialization inputInit = new UserInput.InputInitialization(_playerData);
            //inputInit.Initialization();
        }
    }
}
