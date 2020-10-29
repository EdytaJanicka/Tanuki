using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MotherConversation : MonoBehaviour
{
    public GameObject mother;
    public GameObject player;
    public NPCConversation myConversation;
    public GameObject buttonE;
    [SerializeField] private bool isTalking = false;
    private bool inAField = false;
    public GameObject movement;
    public GameObject camera;


    void Start()
    {
        buttonE.SetActive(false);
    }

   
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.E) && inAField == true && isTalking == false)
        {
            ConversationManager.Instance.StartConversation(myConversation);
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
        camera.GetComponent<CameraMovement>().enabled = false;
        movement.GetComponent<PlayerMovement>().stopMovement = false;
    }

    public void StartMoving()
    {
        camera.GetComponent<CameraMovement>().enabled = true;
        movement.GetComponent<PlayerMovement>().stopMovement = true;
    }
}
