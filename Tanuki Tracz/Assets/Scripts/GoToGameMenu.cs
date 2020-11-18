using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameMenu : MonoBehaviour
{
    public void LoadGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
    

}