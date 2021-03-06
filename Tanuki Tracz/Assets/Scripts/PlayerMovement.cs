﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float gravity = -9.81f;
    public float speed = 10f;
    public bool stopMovement = true;
    Vector3 velocity;
    public Vector3 startPos;
    public Animator animator;
    public GameObject tanukiBody;
    public AudioSource walking;
    public MotherConversation mother;

    private void Start()
    {
        walking = GetComponent<AudioSource>();
        Cursor.visible = false;
    }
    void Awake()
    {
        
        Debug.Log("Hmmmmmmmm");
        if(GameManager.instance.position != startPos)
        {
           Debug.Log("Działa");
            Debug.Log(GameManager.instance.position);
            Debug.Log(transform.localPosition);
            transform.position = GameManager.instance.position;
           Debug.Log(GameManager.instance.position);
            Debug.Log(transform.localPosition);

        }
        Debug.Log("Nie działa");
        
    }

    
    void Update()
    {
        
        float x = 0;
        float z = 0;
        
        if (stopMovement)
        {
             x = Input.GetAxis("Horizontal");
             z = Input.GetAxis("Vertical");
        }
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (x != 0 || z != 0)
        {
            animator.SetBool("Run", true);
            if(!walking.isPlaying)walking.Play();
            
        }
        else
        {
            animator.SetBool("Run", false);
            walking.Stop();
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity);

      //if(mother.isTalking == true)
      //  {
      //      Cursor.visible = true;
      //  }  
    }

    public void EnableCursor()
    {
        Cursor.visible = false;
    }
    public void DisableCursor()
    {
        Cursor.visible = true;
    }
}
