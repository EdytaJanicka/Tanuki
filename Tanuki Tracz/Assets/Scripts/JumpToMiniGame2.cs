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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inAField == true && mother.isAgreedInConversation == 3)
        {
           
            buttonE.SetActive(false);

        }
    }
}
