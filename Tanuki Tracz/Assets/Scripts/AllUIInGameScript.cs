﻿using System.Collections;
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
    public GameObject comics7;
    public GameObject comics8;
    public GameObject escSettings;
    public GameObject eButton;
    public GameObject questBar;
    public GameObject questBar1;
    public GameObject allPanels;
    public PlayerMovement movement;
    Text moneyvalue;
    public GameObject money;


    void Start()
    {
        moneyvalue = money.GetComponent<Text>();
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
        comics7.SetActive(false);
        comics8.SetActive(false);
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
            movement.DisableCursor();

            if (Time.timeScale >= 1.0f)
            {
                Time.timeScale = 0.001f;
            }
            

            else
            {
            Time.timeScale = 1.0f;
            escSettings.SetActive(false);
            }

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

    public void ShowPanel7()
    {
        comics7.SetActive(true);
    }

    public void ShowPanel8()
    {
        comics7.SetActive(false);
        comics8.SetActive(true);
    }

    public void TheEndOfPanelsAndGame()
    {
        StartofPanels();
        Invoke("ShowPanel7", 0.0f);
        Invoke("ShowPanel8", 5.0f);
        Invoke("ShowCredits", 10.0f);

    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void EndofPanels()
    {
        allPanels.SetActive(false);
    }
    public void StartofPanels()
    {
        allPanels.SetActive(true);
    }

    public void money1()
    {
        moneyvalue.text = "1/3";
    }

    public void money2()
    {
        moneyvalue.text = "2/3";
    }

    public void money3()
    {
        moneyvalue.text = "3/3";
    }
}
