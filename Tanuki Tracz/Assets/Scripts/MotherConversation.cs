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
    public GameObject buttonE;
    [SerializeField] private bool isTalking = false;
    private bool inAField = false;
    public GameObject movement;
    public GameObject camera1;
    public int isAgreedInConversation = 0;
    public GameObject quest1;


    void Start()
    {
        buttonE.SetActive(false);
    }

   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false && isAgreedInConversation == 0)
        {
            ConversationManager.Instance.StartConversation(myConversation);
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

}
