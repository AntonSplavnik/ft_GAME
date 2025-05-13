using Manager;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Visual_Feedback
{
	public class LevelComplete : MonoBehaviour
	{
		public void LoadNextLevel()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			GameManager.levelNumber++;
		}
	}
}