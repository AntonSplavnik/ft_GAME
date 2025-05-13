using TMPro;
using UnityEngine;

namespace Manager
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        private float _elapsedTime;
        private HighScore _highScore;
    
        void Start()
        {
            _highScore = GetComponent<HighScore>();
        }
        
        //Update is called once per frame
        void Update()
        { 
            _elapsedTime += Time.deltaTime;
            timerText.text = _highScore.ElapseTime.ToString("F2");
            // timerText.text = elapsedTime.ToString("F2");
        }
    }
}
