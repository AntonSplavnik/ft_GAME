using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Menus
{
    public class SelectLevel : MonoBehaviour
    {
        public void MainMenu()
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);

        }

        public void Level1()
        {
            SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);

        }

        public void Level2()
        {
            SceneManager.LoadSceneAsync("Level2", LoadSceneMode.Single);

        }

        public void Level3()
        {
            SceneManager.LoadSceneAsync("Level3", LoadSceneMode.Single);

        }


    }
}