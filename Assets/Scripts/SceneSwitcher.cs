
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Public method to switch scenes
    public void SwitchScene(string sceneName)
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneName);
    }
}

