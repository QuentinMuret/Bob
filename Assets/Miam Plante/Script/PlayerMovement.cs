﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float direction;
    public float runSpeed = 50;
    bool jump=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal")*runSpeed;
        animator.SetFloat("speed", Mathf.Abs(direction));
        animator.SetBool("isAttacking", false);
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            
            
        }

        if (Input.GetButtonDown("Fire1")) 
        {
            animator.SetBool("isAttacking", true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Interaction");
        }

        
    }

    public void OnLanding()
    {
        
        
    }

    private void FixedUpdate()
    {
        if (!controller.isCharging)
        {
            controller.Move(direction * Time.fixedDeltaTime, false, jump);
        }
            jump = false;
        
    }
}
