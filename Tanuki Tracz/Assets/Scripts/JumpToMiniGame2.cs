using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToMiniGame2 : MonoBehaviour
{
    public GameObject buttonE;
    private bool inAField = false;
    public MotherConversation mother;
    public GameObject mainCamera;
    public GameObject camera2;

    void Start()
    {
        buttonE.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation == 3)
        {
            mainCamera.SetActive(false);
            camera2.SetActive(true);
            buttonE.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonE.SetActive(true);
        inAField = true;

    }

    private void OnTriggerExit(Collider other)
    {
        buttonE.SetActive(false);
        inAField = false;
    }


}
