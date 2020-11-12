using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumptoMiniGame : MonoBehaviour
{
    public GameObject buttonE;
    private bool inAField = false;
    public MotherConversation mother;
    
    
    void Start()
    {
        if (GameManager.instance.washingComplete == true)
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        buttonE.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation == 1)
        {
            GameManager.instance.SavePosition();
            SceneManager.LoadScene("MiniGame1");
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
