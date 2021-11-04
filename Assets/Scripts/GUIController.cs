using System;
using UnityEngine;
using TMPro;

namespace Core
{
    public class GUIController : IInitialization
    {
        //Временное решение
        private GameObject _blueKey;
        private GameObject _yellowKey;
        private GameObject _redKey;
        private string _maxScore = "0";
        private string _score = "0";
        private TMP_Text _scoreText;
        private PlayerData _playerData;

        #region Events
        public event Action onScoreUpdate;
        public void scoreUpdate()
        {
            if (onScoreUpdate != null)
            {
                onScoreUpdate();
            }
        }
        public event Action onKeyUpdate;
        public void keyUpdate()
        {
            if (onKeyUpdate != null)
            {
                onKeyUpdate();
            }
        }
        #endregion

        public GUIController(PlayerData data)
        {
            _playerData = data;
        }

        public void Initialization()
        {
            _blueKey = GameObject.Find("BlueKeyImage");
            _yellowKey = GameObject.Find("YellowKeyImage");
            _redKey = GameObject.Find("RedKeyImage");
            _scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
            UpdateScore();
            _blueKey.SetActive(false);
            _yellowKey.SetActive(false);
            _redKey.SetActive(false);

            GameEventSystem.current.onScoreUpdate += UpdateScore;
            GameEventSystem.current.onKeyUpdate += KeyUpdate;
        }
        public void UpdateScore()
        {
            _maxScore = _playerData.MaxScore.ToString();
            _score = _playerData.Score.ToString();
            _scoreText.text = _score + " / " + _maxScore;
        }

        public void KeyUpdate()
        {
            _blueKey.SetActive(_playerData.BlueKey);
            _yellowKey.SetActive(_playerData.YellowKey);
            _redKey.SetActive(_playerData.RedKey);
        }

        ~GUIController()
        {
            GameEventSystem.current.onScoreUpdate -= UpdateScore;
            GameEventSystem.current.onKeyUpdate -= KeyUpdate;
        }
    }
}
