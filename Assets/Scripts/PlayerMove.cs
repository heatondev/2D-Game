using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform Player;
    public Animator animator;
    public CharacterController2D controller;
    float horizontalMove;
    public float runSpeed = 40f;
    bool jump = false;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        if (Input.GetButton("Run"))
        {
            runSpeed = 40f;
            Debug.Log("Run button has been pushed");
           
        }
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("fire", true);
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
       // Debug.Log(runSpeed);
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
   
}
