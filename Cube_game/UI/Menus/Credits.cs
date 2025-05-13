using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Menus
{
    public class Credits : MonoBehaviour
    {
        
        public void MainMenu()
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
        public void Quit()
        { 
            Application.Quit();
        }
    }
}
 