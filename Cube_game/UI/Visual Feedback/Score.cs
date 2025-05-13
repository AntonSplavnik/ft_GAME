using UnityEngine;
using UnityEngine.UI;

namespace UI.Visual_Feedback
{
	public class Score : MonoBehaviour
	{
		[SerializeField] Transform player;
		[SerializeField] Text scoreText;
		private float _elapsedTime;
		
		// Update is called once per frame
		void Update()
		{
			scoreText.text = player.position.z.ToString("0");
			// _elapsedTime += Time.deltaTime;
			// scoreText.text = _elapsedTime.ToString("F2");
		}
	}
}