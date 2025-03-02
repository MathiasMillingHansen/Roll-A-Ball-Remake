using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RestartGame()
    {
        // Get the current scene name
        string currentScene = SceneManager.GetActiveScene().name;

        // Reload the current scene
        SceneManager.LoadScene(currentScene);
    }
}
