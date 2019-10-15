using System.Collections;
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
            animator.SetBool("isJumping", true);
            
        }

        if (Input.GetButtonDown("Fire1")) 
        {
            animator.SetBool("isAttacking", true);
        }

        
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
        
    }

    private void FixedUpdate()
    {
        controller.Move(direction*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
