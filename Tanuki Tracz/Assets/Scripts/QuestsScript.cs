using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsScript : MonoBehaviour
{
    public GameObject quest1;
    public GameObject quest2;
    public GameObject quest3;
    public GameObject quest4;
    public GameObject quest5;



    void Start()
    {
        quest1.SetActive(false);
        quest2.SetActive(false);
        quest3.SetActive(false);
        quest4.SetActive(false);
        quest5.SetActive(false);
    }

    public void quest1SetActive()
    {
        quest1.SetActive(true);
    }
    public void quest1SetDesactive()
    {
        quest1.SetActive(false);
    }



    public void quest2SetActive()
    {
        quest2.SetActive(true);
    }
    public void quest2SetDesactive()
    {
        quest2.SetActive(false);
    }



    public void quest3SetActive()
    {
        quest3.SetActive(true);
    }
    public void quest3SetDesactive()
    {
        quest3.SetActive(false);
    }



    public void quest4SetActive()
    {
        quest4.SetActive(true);
    }
    public void quest4SetDesactive()
    {
        quest4.SetActive(false);
    }




    public void quest5SetActive()
    {
        quest5.SetActive(true);
    }
    public void quest5SetDesactive()
    {
        quest5.SetActive(false);
    }

}
