using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.UI;

public class MotherConversation : MonoBehaviour
{
    public GameObject mother;
    public GameObject player;
    public NPCConversation myConversation;
    public NPCConversation myConversation1;
    public NPCConversation myConversation2;
    public NPCConversation myConversation3;
    public NPCConversation myConversation4;
    public GameObject buttonE;
    [SerializeField] public bool isTalking = false;
    private bool inAField = false;
    public GameObject movement;
    public GameObject camera1;
    public GameObject mainCamera;
    public GameObject cameraTalking;
    public int isAgreedInConversation = 0;
 


    void Start()
    {
        buttonE.SetActive(false);

        if (GameManager.instance.washingComplete == true)
        {
            Agreed();
            Agreed();
        }
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 0)
        {
            ConversationManager.Instance.StartConversation(myConversation);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 1)
        {
            ConversationManager.Instance.StartConversation(myConversation1);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 2)
        {
            ConversationManager.Instance.StartConversation(myConversation2);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 3)
        {
            ConversationManager.Instance.StartConversation(myConversation1);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 4)
        {
            ConversationManager.Instance.StartConversation(myConversation3);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 5)
        {
            ConversationManager.Instance.StartConversation(myConversation1);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 6)
        {
            ConversationManager.Instance.StartConversation(myConversation4);
            mainCamera.SetActive(false);
            cameraTalking.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
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
        isTalking = false;
    }

    public void IsTalking()
    {
        isTalking = false;
    }

    public void StopMoving()
    {
        camera1.GetComponent<CameraMovement>().enabled = false;
        movement.GetComponent<PlayerMovement>().stopMovement = false;
    }

    public void StartMoving()
    {
        camera1.GetComponent<CameraMovement>().enabled = true;
        movement.GetComponent<PlayerMovement>().stopMovement = true;
    }
    public void Agreed()
    {
        isAgreedInConversation += 1;
    }
    public void SwapCameras()
    {
        mainCamera.SetActive(true);
        cameraTalking.SetActive(false);
    }

}
