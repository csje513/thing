using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuPlayButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
