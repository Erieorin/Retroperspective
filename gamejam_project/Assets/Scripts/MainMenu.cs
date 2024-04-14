using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string scene;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Return()
    {
        SceneManager.LoadSceneAsync("MenuScene");
    }    
}
