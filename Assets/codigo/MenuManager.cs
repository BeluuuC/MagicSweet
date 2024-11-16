using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyGame
{
    public class MenuManager : MonoBehaviour
    {
        public string sceneName = "Scenes/SampleScene"; 

        
        public void StartGame()
        {
            // Cargar la escena especificada
            SceneManager.LoadScene(sceneName);
        }

        
    }
}
