using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("AR Luffy");
    }
    
    public void QuitGame() 
    {
        Application.Quit();
    }
}
