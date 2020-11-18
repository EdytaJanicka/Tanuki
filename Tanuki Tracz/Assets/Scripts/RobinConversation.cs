using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.UI;

public class RobinConversation : MonoBehaviour
{
    public GameObject robin;
    public GameObject player;
    public NPCConversation myRobinConversation;
    public NPCConversation myRobinConversation1;
    public GameObject buttonE;
    [SerializeField] public bool isTalking = false;
    private bool inAField = false;
    public GameObject movement;
    public GameObject camera1;
    public GameObject mainCamera;
    public GameObject cameraTalkingWithRobin;
    public MotherConversation mother;
    private bool talkingWithRobin = false;

    void Start()
    {
        buttonE.SetActive(false);
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation >= 0 && talkingWithRobin == true)
        {
            ConversationManager.Instance.StartConversation(myRobinConversation);
            mainCamera.SetActive(false);
            cameraTalkingWithRobin.SetActive(true);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }

        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation >= 7 && talkingWithRobin == true)
        {
            ConversationManager.Instance.StartConversation(myRobinConversation1);
            buttonE.SetActive(false);
            isTalking = true;
            StopMoving();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        buttonE.SetActive(true);
        inAField = true;
        talkingWithRobin = true;
        mother.isTalking = true;

    }

    private void OnTriggerExit(Collider other)
    {
        buttonE.SetActive(false);
        isTalking = false;
        talkingWithRobin = false;
        mother.isTalking = false;

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

    public void SwapCameras2()
    {
        mainCamera.SetActive(true);
        cameraTalkingWithRobin.SetActive(false);
    }

}
