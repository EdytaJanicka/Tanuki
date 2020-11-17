using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagerController : MonoBehaviour
{
    public GameObject cameraCarpet;
    public GameObject cameraWater;

    void Start()
    {
        cameraCarpet.SetActive(false);
        cameraWater.SetActive(false);
    }

    
}
