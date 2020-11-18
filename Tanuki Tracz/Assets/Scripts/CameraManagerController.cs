using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagerController : MonoBehaviour
{
    public GameObject cameraCarpet;
    public GameObject cameraWater;
    public GameObject cameraTalkingWithMum;
    public GameObject cameraTalkingWithRobin;


    void Start()
    {
        cameraCarpet.SetActive(false);
        cameraWater.SetActive(false);
        cameraTalkingWithMum.SetActive(false);
        cameraTalkingWithRobin.SetActive(false);
    }

    
}
