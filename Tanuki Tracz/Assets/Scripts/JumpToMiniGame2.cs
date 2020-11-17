using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToMiniGame2 : MonoBehaviour
{
    public GameObject buttonE;
    private bool inAField = false;
    public MotherConversation mother;
    public GameObject mainCamera;
    public GameObject cameraCarpet;

    void Start()
    {
         buttonE.SetActive(false);
         cameraCarpet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation == 3)
        {
            cameraCarpet.SetActive(true);
            mainCamera.SetActive(false);
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
