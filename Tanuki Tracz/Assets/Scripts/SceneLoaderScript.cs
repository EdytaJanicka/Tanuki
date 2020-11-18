using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GAME");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

}
