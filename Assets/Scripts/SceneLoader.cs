// Purpose: To use unity scene manager to load a new scene (typically added to a button OnClick method

using UnityEngine;
// New Unity backend to handle the scene loading
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

   // Template for loading scenes. Must pass a string utilizing Unity Inspector (provided by LoadScene constructor) 

   public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
