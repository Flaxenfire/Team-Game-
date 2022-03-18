using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public gameStart turnManager;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

    public Rigidbody2D rb;


    // Update is called once per frame
    void Update()
    {
        if (turnManager.player1turn)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
            if (Input.GetButtonDown("Fire3"))
            {
                turnManager.player1turn = false;
                turnManager.player1attack = true;
                rb.drag = 20;
            }
        
        }
        else if (turnManager.player2attack)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire4"))
            {
                turnManager.player1turn = true;
                turnManager.player2attack = false;
                rb.drag = 0;
            }
        }
        else if (turnManager.player2turn)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                turnManager.player2attack = true;
                turnManager.player2turn = false;
            }
        }

    }
    void FixedUpdate () {

        if (turnManager.player1turn)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
        }
    








}
