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
    public GameObject eButton;
    public GameObject questBar;
    public bool questBarActive;

    void Start()
    {
         buttonE.SetActive(false);
         cameraCarpet.SetActive(false);
         questBarActive = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation == 3 && mother.isTalking == true)
        {
            cameraCarpet.SetActive(true);
            mainCamera.SetActive(false);
            buttonE.SetActive(false);
            SetQuestBarActive();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonE.SetActive(true);
        inAField = true;
        mother.isTalking = true;
    }

    private void OnTriggerExit(Collider other)
    {
        buttonE.SetActive(false);
        inAField = false;
        mother.isTalking = false;
    }

    public void SetQuestBarActive()
    {
        eButton.SetActive(true);
        questBar.SetActive(true);
        questBarActive = true;

    }

}
