using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Moverment : MonoBehaviour
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
        if (turnManager.player2turn)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
            if (Input.GetButtonDown("Fire3"))
            {
                turnManager.player2attack = true;
                turnManager.player2turn = false;
                rb.drag = 20;
            }

        }
        else if (turnManager.player1attack)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire4"))
            { 
                turnManager.player1attack = false;
                turnManager.player2turn = true;
                rb.drag = 0;
            }
        }
        else if (turnManager.player1turn)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                turnManager.player1turn = false;
                turnManager.player1attack = true;

            }
        }

    }
    void FixedUpdate()
    {

        if (turnManager.player2turn)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
    }
}

