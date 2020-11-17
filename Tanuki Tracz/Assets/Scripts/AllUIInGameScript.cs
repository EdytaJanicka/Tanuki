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
    public GameObject eButton;
    public GameObject questBar;
    public GameObject questBar1;
    public GameObject allPanels;


    void Start()
    {
        questBar.SetActive(false);
        eButton.SetActive(false);
        escSettings.SetActive(false);
        questBar1.SetActive(false);
        comics1.SetActive(true);
        comics2.SetActive(false);
        comics3.SetActive(false);
        comics4.SetActive(false);
        comics5.SetActive(false);
        comics6.SetActive(false);
        if (GameManager.instance.washingComplete == false)
        {
            Invoke("ShowPanel2", 4.0f);
            Invoke("ShowPanel3", 8.0f);
            Invoke("ShowPanel4", 12.0f);
            Invoke("ShowPanel5", 16.0f);
            Invoke("ShowPanel6", 20.0f);
            Invoke("EndofPanels", 24.0f);
        }
        if (GameManager.instance.washingComplete == true)
        {
            EndofPanels();
        }
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

    public void ShowPanel2()
    {
        comics1.SetActive(false);
        comics2.SetActive(true);
    }

    public void ShowPanel3()
    {
        comics2.SetActive(false);
        comics3.SetActive(true);
    }

    public void ShowPanel4()
    {
        comics3.SetActive(false);
        comics4.SetActive(true);
    }

    public void ShowPanel5()
    {
        comics4.SetActive(false);
        comics5.SetActive(true);
    }

    public void ShowPanel6()
    {
        comics5.SetActive(false);
        comics6.SetActive(true);
    }
    public void EndofPanels()
    {
        allPanels.SetActive(false);
    }
}
