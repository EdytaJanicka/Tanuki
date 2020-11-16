using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperatorScript : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    private void Start()
    {
        camera1.SetActive(false);
    }
}
