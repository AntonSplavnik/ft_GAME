using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Menus
{
    public class Menu : MonoBehaviour
    {
        //public void StartGame_Nextlevel ()
        //{

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
        //}

        public void StartGame ()

        {
            SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
        }

        public void SelectLevel ()
        {
            SceneManager.LoadSceneAsync("SelectLevel", LoadSceneMode.Single);
            
        }
    }
}
