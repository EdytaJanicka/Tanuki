using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AllUIInGameScript : MonoBehaviour
{
    public GameObject comics1;
    public GameObject comics2;
    public GameObject comics3;
    public GameObject comics4;
    public GameObject comics5;
    public GameObject comics6;
    public GameObject escSettings;
    public GameObject eButtonQuest;
    public GameObject questBar;

    void Start()
    {
        escSettings.SetActive(false);
        eButtonQuest.SetActive(false);
        questBar.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escSettings.SetActive(true);
            
            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = 0.00001f;
            }
            }

            else
            {
            Time.timeScale = 1.0f;
            }
    }

    public void GoBack()
    {
        escSettings.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
