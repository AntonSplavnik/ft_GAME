    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using TMPro;
    using UnityEngine;

    namespace Manager
    {
        public class HighScore : MonoBehaviour
        {
            [SerializeField] private TextMeshProUGUI timerText;
            [SerializeField] private TextMeshProUGUI highScore;
            public float ElapseTime { get; private set; }
            private float StartTime { get; set; }
            private float Delta { get; set; }

            private float HighScoreTime
            {
                get => SaveManager.Instance.GetHighScoreForLevel(GameManager.levelNumber);
                set => SaveManager.Instance.SaveHighScoreForLevel(GameManager.levelNumber, value);
            }

            void Start()
            {
                GameManager.Instance.OnGameStarted += OnGameStarted;
                GameManager.Instance.OnLevelEnded += OnLevelEnded;
                Debug.Log($"Game started at: {StartTime}");
                highScore.text = HighScoreTime.ToString("F2");
            }

            private void Update()
            {
                ElapseTime = Time.time;
                timerText.text = ElapseTime.ToString("F2"); 
            }

            void OnGameStarted()
            {
                StartTime = Time.time;
            }
            
            void OnLevelEnded()
            {

                if (ElapseTime > HighScoreTime)
                {
                    HighScoreTime = ElapseTime;
                    highScore.text = HighScoreTime.ToString();
                }
                Debug.Log("Your time:" + TimeSpan.FromMilliseconds(HighScoreTime));
                // Debug.Log("Your time:" + TimeSpan.FromMilliseconds(delta));
                
            }
            
        }
    }